
namespace Common.Application.DTOs.Members
{
    public record MemberRolesDTO(string GuildId, string UserId, IEnumerable<string> RoleIdList);
}
