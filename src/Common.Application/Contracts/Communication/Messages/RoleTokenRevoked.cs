
using TGF.CA.Application.Contracts.Communication;

namespace Common.Application.Contracts.Communication.Messages
{
    public record RoleTokenRevoked(ulong[] DiscordRoleIdList)
        :IIntegrationMessageContent;
}
