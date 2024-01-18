using Common.Presentation;
using FluentValidation;
using System.Reflection;

namespace Members.API.Validation
{
    public abstract class SortByValidator<T> : AbstractValidator<string>
        where T : class
    {
        public SortByValidator()
        {
            RuleFor(x => x)
                .NotEmpty().WithMessage(CommonPresentationErrors.Validation.SortBy.SortByEmpty)
                .Must(BeAValidProperty).WithMessage(CommonPresentationErrors.Validation.SortBy.SortByInvalid);
        }

        private bool BeAValidProperty(string aPropName)
        {
            var lPropertyNames = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance)
                                                       .Select(prop => prop.Name);

            return lPropertyNames.Contains(aPropName);
        }
    }
}
