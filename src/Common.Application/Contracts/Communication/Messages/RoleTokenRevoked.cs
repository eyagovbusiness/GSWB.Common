
using Common.Domain.ValueObjects;
using TGF.CA.Application.Contracts.Communication;

namespace Common.Application.Contracts.Communication.Messages
{
    public record RoleTokenRevoked(IEnumerable<RoleKey> RoleIdList)
        :IIntegrationMessageContent;
}
