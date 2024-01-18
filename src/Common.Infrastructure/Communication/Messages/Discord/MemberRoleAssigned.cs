using Common.Application.DTOs.Discord;

namespace TGF.CA.Infrastructure.Communication.Messages.Discord
{
    public record MemberRoleAssigned(string DiscordUserId, DiscordRoleDTO[] DiscordRoleList);
}
