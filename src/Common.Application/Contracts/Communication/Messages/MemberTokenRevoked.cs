using Common.Domain.ValueObjects;
using TGF.CA.Application.Contracts.Communication;

namespace Common.Application.Contracts.Communication.Messages
{
    public record MemberTokenRevoked(MemberKey[] MemberIdList)
        : IIntegrationMessageContent;
}
