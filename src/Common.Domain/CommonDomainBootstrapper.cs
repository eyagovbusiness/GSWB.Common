using Common.Domain.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Builder;

namespace Common.Domain
{
    /// <summary>
    /// Provides methods for configuring and using the common domain components shared across several web application projects in this solution.
    /// </summary>
    public static class CommonDomainBootstrapper
    {
        /// <summary>
        /// Configures the necessary common domain services for the application shared across several web application projects in this solution.
        /// </summary>
        public static WebApplicationBuilder ConfigureCommonDomain(this WebApplicationBuilder aWebApplicationBuilder)
        {
            aWebApplicationBuilder.Services.AddValidatorsFromAssemblyContaining<DiscordIdValidator>();
            return aWebApplicationBuilder;
        }

        //public static void UseCommonDomain(this WebApplication aWebApplication)
        //{
        //}
    }
}
