using Common.Domain.ValueObjects;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using TGF.CA.Infrastructure.Discovery;
using TGF.CA.Infrastructure.Security.Identity;
using TGF.CA.Infrastructure.Security.Identity.Authorization.Permissions;
using TGF.CA.Infrastructure.Security.Secrets;

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
        public static void UseCommonInfrastructure(this WebApplication aWebApplication)
        {
            aWebApplication.UseCookiePolicy(new CookiePolicyOptions()//call before any middelware with auth
            {
                MinimumSameSitePolicy = SameSiteMode.Lax
            });
        }

    }
}
