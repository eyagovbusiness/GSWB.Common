using Common.Application.DTOs.Discord;

namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record RoleCreated(string GuildId, DiscordRoleDTO DiscordRole);
}
