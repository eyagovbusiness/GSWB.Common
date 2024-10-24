
namespace Common.Application.DTOs.Roles
{
    public record GuildRolesUpdateDTO(string GuildId, IEnumerable<RoleUpdateDTO> RoleUpdates);
}
