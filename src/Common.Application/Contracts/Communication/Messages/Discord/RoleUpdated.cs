using Common.Application.DTOs.Discord;

namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record RoleUpdated(string GuildId, DiscordRoleDTO DiscordRole);
}
