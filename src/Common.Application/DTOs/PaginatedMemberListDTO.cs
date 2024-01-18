
namespace Common.Application.DTOs
{
    public record PaginatedRoleListDTO(
        int CurrentPage,
        int TotalPages,
        int PageSize,
        int TotalCount,
        RoleDTO[] RoleList
    );
}