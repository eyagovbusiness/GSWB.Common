
namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record MemberAvatarUpdated(string UserId, string GuildId, string NewAvatarUrl);
}
