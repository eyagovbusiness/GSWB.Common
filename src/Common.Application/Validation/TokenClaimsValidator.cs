using FluentValidation;
using System.Security.Claims;


namespace Common.Application.Validation
{
    public class TokenClaimsValidator : AbstractValidator<ClaimsPrincipal>
    {
        public TokenClaimsValidator()
        {
            RuleFor(x => x.FindFirstValue(ClaimTypes.NameIdentifier))
                .NotEmpty().WithErrorCode(CommonApplicationErrors.Validation.TokenClaims.TokenClaims_NameIdentifier);

            RuleFor(x => x.FindFirstValue(ClaimTypes.Name))
                .NotEmpty().WithErrorCode(CommonApplicationErrors.Validation.TokenClaims.TokenClaims_Name);

            RuleFor(x => x.FindFirstValue(ClaimTypes.GivenName))
                .NotEmpty().WithErrorCode(CommonApplicationErrors.Validation.TokenClaims.TokenClaims_GivenName);
        }
    }
}
