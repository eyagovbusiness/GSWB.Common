
using TGF.CA.Infrastructure.Communication.Messages;

namespace Common.Infrastructure.Communication.Messages
{
    public record MemberTokenRevoked(Guid[] MemberIdList)
        : IIntegrationMessageContent;
}
