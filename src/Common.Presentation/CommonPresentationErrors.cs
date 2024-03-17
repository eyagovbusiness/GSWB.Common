
using System.Net;
using TGF.Common.ROP.Errors;

namespace Common.Presentation
{
    public class CommonPresentationErrors
    {
        public class Validation
        {
            public class Pagination
            {
                public const string Page = "Validation.Pagination.Page";
                public const string PageSize = "Validation.Pagination.PageSize";
            }
            public class SortBy
            {
                public const string SortByEmpty = "Validation.SortByEmpty";
                public static Error SortByInvalid => new(
                    "Validation.SortByInvalid",
                    "The sortBy field must be a valid property name of the target object."
                );

            }
        }
    }
}
