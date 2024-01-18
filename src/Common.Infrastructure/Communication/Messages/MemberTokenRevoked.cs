
using TGF.CA.Infrastructure.Communication.Messages;

namespace Common.Infrastructure.Communication.Messages
{
    public record MemberTokenRevoked(string[] DiscordUserIdList)
        : IIntegrationMessageContent;
}
