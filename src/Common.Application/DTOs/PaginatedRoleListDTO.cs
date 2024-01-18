
namespace Common.Application.DTOs
{
    public record PaginatedMemberListDTO(
        int CurrentPage,
        int TotalPages,
        int PageSize,
        int TotalCount,
        MemberDetailDTO[] MemberList
    );
}