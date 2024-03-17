using Common.Presentation;
using FluentValidation;
using System.Reflection;
using TGF.Common.ROP.Errors;

namespace Members.API.Validation
{
    public abstract class SortByValidator<T> : AbstractValidator<string>
        where T : class
    {
        public SortByValidator()
        {
            RuleFor(x => x)
                .NotEmpty().WithErrorCode(CommonPresentationErrors.Validation.SortBy.SortByEmpty)
                .Must(BeAValidProperty).WithROPError(CommonPresentationErrors.Validation.SortBy.SortByInvalid);
        }

        private bool BeAValidProperty(string aPropName)
        {
            var lPropertyNames = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                                       .Select(prop => prop.Name);
            return lPropertyNames.Contains(aPropName);
        }
    }
}
