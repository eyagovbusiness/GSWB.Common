using Common.Application.DTOs.Members;

namespace Common.Application.DTOs.Roles
{
    public record PaginatedMemberListDTO(
        int CurrentPage,
        int TotalPages,
        int PageSize,
        int TotalCount,
        MemberDetailDTO[] MemberList
    );
}