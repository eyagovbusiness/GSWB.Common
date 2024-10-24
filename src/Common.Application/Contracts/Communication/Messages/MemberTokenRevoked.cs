using TGF.CA.Application.Contracts.Communication;

namespace Common.Application.Contracts.Communication.Messages
{
    public record MemberTokenRevoked(Guid[] MemberIdList)
        : IIntegrationMessageContent;
}
