using Common.Domain.ValueObjects;

namespace Common.Application.DTOs
{
    public record RoleDTO(string Name, PermissionsEnum Permissions, RoleTypesEnum Type, string? Description, string DiscordRoleId, byte Position);
}
