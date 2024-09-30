
namespace TGF.CA.Infrastructure.Communication.Messages.Discord
{
    public record MemberAvatarUpdated(string UserId, string GuildId, string NewAvatarUrl);
}
