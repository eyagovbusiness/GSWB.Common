using Common.Application.DTOs.Discord;

namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record MemberRoleAssigned(string UserId, string GuildId, DiscordRoleDTO[] DiscordRoleList);
}
