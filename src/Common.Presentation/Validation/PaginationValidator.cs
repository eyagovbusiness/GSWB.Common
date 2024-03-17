using FluentValidation;

namespace Common.Presentation.Validation
{
    public class PaginationValidator : AbstractValidator<PaginationValParams>
    {
        public PaginationValidator()
        {
            RuleFor(x => x.Page)
                .GreaterThan(0).WithErrorCode(CommonPresentationErrors.Validation.Pagination.Page_Code);

            RuleFor(x => x.PageSize)
                .GreaterThan(0).WithErrorCode(CommonPresentationErrors.Validation.Pagination.PageSize_Code);
        }
    }
    public record PaginationValParams(int Page, int PageSize);
}
