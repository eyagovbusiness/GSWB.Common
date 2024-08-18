using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.Roles
{
    public record RoleDTO(string Name, PermissionsEnum Permissions, RoleTypesEnum Type, string? Description, string Id, byte Position);
}
