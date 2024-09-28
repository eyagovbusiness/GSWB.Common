
namespace TGF.CA.Infrastructure.Communication.Messages.Discord
{
    /// <summary>
    /// Message sent when the bot is added to a new Guild, with basic information about the Guild where the bot was added.
    /// </summary>
    public record GuildAdded(string GuildId, string GuildName, string IconUrl);
}
