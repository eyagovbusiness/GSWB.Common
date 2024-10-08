using Common.Domain.ValueObjects;
using Common.Infrastructure.DataAccess.DbContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TGF.CA.Infrastructure.Discovery;
using TGF.CA.Infrastructure.Security.Identity;
using TGF.CA.Infrastructure.Security.Identity.Authorization.Permissions;
using TGF.CA.Infrastructure.Security.Secrets;
using TGF.CA.Infrastructure.DB.PostgreSQL;
using TGF.CA.Infrastructure;
using Microsoft.Extensions.Logging;

namespace Common.Infrastructure
{
    /// <summary>
    /// Provides methods for configuring and using the common infrastructure components shared across several web application projects in this solution.
    /// </summary>
    public static class CommonInfrastructureBootstrapper
    {
        /// <summary>
        /// Configures the necessary common infrastructure services for the application shared across several web application projects in this solution.
        /// </summary>
        /// <param name="aWebApplicationBuilder">The web application builder.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Configures Consul discovery service.</description></item>
        /// <item><description>Configures Vault secrets manager.</description></item>
        /// <item><description>Configures Identity services adding the common authentication and authorization configurations for this solution.</description></item>
        /// </list>
        /// </remarks>
        public static async Task ConfigureCommonInfrastructureAsync(this WebApplicationBuilder aWebApplicationBuilder)
        {
            aWebApplicationBuilder.Services.AddDiscoveryService(aWebApplicationBuilder.Configuration);
            aWebApplicationBuilder.Services.AddVaultSecretsManager();

            await aWebApplicationBuilder.Services.AddCustomIdentityAsync(aWebApplicationBuilder.Configuration, aWebApplicationBuilder.Environment);
            aWebApplicationBuilder.Services.AddSingleton<IAuthorizationHandler, PermissionAuthorizationHandler<PermissionsEnum>>();
            aWebApplicationBuilder.Services.AddSingleton<IAuthorizationPolicyProvider, PermissionAuthorizationPolicyProvider<PermissionsEnum>>();

            await aWebApplicationBuilder.ConfigureCommonDataProtectionKeysAsync();

        }

        /// <summary>
        /// Configures common Data Protection keys for use across multiple services. 
        /// This method adds PostgreSQL as the persistent store for Data Protection keys
        /// and sets a shared application name to enable multiple services to share the same encryption keys.
        /// </summary>
        /// <param name="aWebApplicationBuilder">
        /// The <see cref="WebApplicationBuilder"/> used to configure the application's services.
        /// </param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <remarks>
        /// This method ensures that all services that use this configuration will persist their Data Protection keys
        /// to a shared PostgreSQL database. This allows multiple services to encrypt and decrypt sensitive data (such as cookies and tokens) 
        /// using a consistent set of keys. The keys are shared across services by specifying a common application name 
        /// ("SharedAuthDataProtectionKeys") using the <see cref="SetApplicationName"/> method.
        /// </remarks>
        public static async Task ConfigureCommonDataProtectionKeysAsync(this WebApplicationBuilder aWebApplicationBuilder)
        {
            await aWebApplicationBuilder.Services.AddPostgreSQL<DataProtectionKeysDbContext>("SharedDataProtectionKeys");

            aWebApplicationBuilder.Services.AddDataProtection()
                .PersistKeysToDbContext<DataProtectionKeysDbContext>()
                .SetApplicationName("SharedAuthDataProtectionKeys"); // Shared application name for all services
        }

        /// <summary>
        /// Applies the common infrastructure configurations shared across several web application projects in this solution the web application.
        /// </summary>
        /// <param name="aWebApplication">The Web application instance.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Configures cookie policy to Lax.</description></item>
        /// </list>
        /// </remarks>
        public static async Task UseCommonInfrastructure(this WebApplication aWebApplication)
        {
            aWebApplication.UseCookiePolicy(new CookiePolicyOptions()//call before any middelware with auth
            {
                MinimumSameSitePolicy = SameSiteMode.Lax
            });
            try
            {
                await aWebApplication.UseMigrations<DataProtectionKeysDbContext>();
            }
            catch (Exception ex)
            {
                // Log the exception to avoid silent failures and make it easier to debug migration issues
                var logger = aWebApplication.Services.GetRequiredService<ILogger<WebApplication>>();
                logger.LogWarning(ex, "Failed to apply migrations for DataProtectionKeysDbContext. Continuing with the application startup...");
            }
        }

    }
}
