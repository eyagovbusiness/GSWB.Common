using FluentValidation;

namespace Common.Presentation.Validation
{
    public class PaginationValidator : AbstractValidator<PaginationValParams>
    {
        public PaginationValidator()
        {
            RuleFor(x => x.Page)
                .GreaterThan(0).WithMessage(CommonPresentationErrors.Validation.Pagination.Page);

            RuleFor(x => x.PageSize)
                .GreaterThan(0).WithMessage(CommonPresentationErrors.Validation.Pagination.PageSize);
        }
    }
    public record PaginationValParams(int Page, int PageSize);
}
