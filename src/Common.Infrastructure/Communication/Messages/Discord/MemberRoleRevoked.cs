using Common.Application.DTOs.Discord;

namespace TGF.CA.Infrastructure.Communication.Messages.Discord
{
    public record MemberRoleRevoked(string UserId, string GuildId, DiscordRoleDTO[] DiscordRoleList);
}
