using Common.Presentation.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Builder;

namespace Common.Presentation
{
    /// <summary>
    /// Provides methods for configuring and using the common infrastructure components shared across several web application projects in this solution.
    /// </summary>
    public static class CommonPresentationBootstrapper
    {
        /// <summary>
        /// Configures the necessary common persentation services for the application shared across several web application projects in this solution.
        /// </summary>
        public static WebApplicationBuilder ConfigureCommonPresentation(this WebApplicationBuilder aWebApplicationBuilder)
        {
            aWebApplicationBuilder.Services.AddValidatorsFromAssemblyContaining<PaginationValidator>();
            return aWebApplicationBuilder;
        }

        //declare here more common use middlewares, but be careful declaring common middleware use order becauyse the order matters! and it may not be a common order that suits all the applications of this project.
    }
}
