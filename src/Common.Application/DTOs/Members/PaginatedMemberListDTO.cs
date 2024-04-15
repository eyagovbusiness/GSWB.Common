using Common.Application.DTOs.Roles;

namespace Common.Application.DTOs.Members
{
    public record PaginatedRoleListDTO(
        int CurrentPage,
        int TotalPages,
        int PageSize,
        int TotalCount,
        RoleDTO[] RoleList
    );
}