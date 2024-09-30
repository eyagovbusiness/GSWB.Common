
namespace TGF.CA.Infrastructure.Communication.Messages.Discord
{
    public record MemberRenamed(string UserId, string GuildId, string NewDisplayName);
}
