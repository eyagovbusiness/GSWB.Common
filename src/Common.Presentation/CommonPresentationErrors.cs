
namespace Common.Presentation
{
    public class CommonPresentationErrors
    {
        public class Validation
        {
            public class Pagination
            {
                public const string Page = "Validation.Pagination.Page:Page number should be minimum equals to 1.";
                public const string PageSize = "Validation.Pagination.PageSize:Page size should be minimum equals to 1.";
            }
            public class SortBy
            {
                public const string SortByEmpty = "Validation.SortByEmpty:The sortBy parameter is not required, but when it is included in the request's header it must be not empty.";
                public const string SortByInvalid = "Validation.SortByInvalid:The sort field must be a valid property name of the target object.";

            }
        }
    }
}
