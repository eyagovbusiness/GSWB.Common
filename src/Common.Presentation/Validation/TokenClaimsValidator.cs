using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Common.Presentation.Validation
{
    public class TokenClaimsValidator : AbstractValidator<ClaimsPrincipal>
    {
        public TokenClaimsValidator()
        {
            RuleFor(x => x.FindFirstValue(ClaimTypes.NameIdentifier))
                .NotEmpty().WithErrorCode(CommonPresentationErrors.Validation.TokenClaims.TokenClaims_NameIdentifier);

            RuleFor(x => x.FindFirstValue(ClaimTypes.Name))
                .NotEmpty().WithErrorCode(CommonPresentationErrors.Validation.TokenClaims.TokenClaims_Name);

            RuleFor(x => x.FindFirstValue(ClaimTypes.GivenName))
                .NotEmpty().WithErrorCode(CommonPresentationErrors.Validation.TokenClaims.TokenClaims_GivenName);
        }
    }
}
