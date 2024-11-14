
namespace Common.Application.Contracts.Communication.Messages.Discord
{
    public record MemberRenamed(string UserId, string GuildId, string NewDisplayName);
}
