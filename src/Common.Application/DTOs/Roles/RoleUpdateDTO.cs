using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.Roles
{
    public record RoleUpdateDTO(PermissionsEnum Permissions, RoleTypesEnum Type, string? Description, string DiscordRoleId);
}
