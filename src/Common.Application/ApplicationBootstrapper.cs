using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using TGF.CA.Application.Validation;

namespace Common.Application
{
    /// <summary>
    /// Provides methods for configuring and using the application layer specific services.
    /// </summary>
    public static class ApplicationBootstrapper
    {
        /// <summary>
        /// Configures the specific application layer required services for this web application.
        /// </summary>
        /// <param name="aServiceList"></param>
        public static void RegisterCommonApplicationServices(this IServiceCollection aServiceList)
        {
            aServiceList.AddValidatorsFromAssemblyContaining<PaginationValidator>();
        }
    }
}
