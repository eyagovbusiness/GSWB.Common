using Common.Domain.ValueObjects;

namespace Common.Application.DTOs
{
    public record RoleUpdateDTO(PermissionsEnum Permissions, RoleTypesEnum Type, string? Description, string DiscordRoleId);
}
