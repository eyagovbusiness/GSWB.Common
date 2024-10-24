using Common.Application.DTOs.Discord;

namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record MemberRoleRevoked(string UserId, string GuildId, DiscordRoleDTO[] DiscordRoleList);
}
