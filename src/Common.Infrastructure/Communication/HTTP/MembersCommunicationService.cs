using Common.Application.Contracts.Services;
using Common.Application.DTOs.Auth;
using Common.Application.DTOs.Members;
using Common.Domain.ValueObjects;
using Common.Infrastructure.Communication.ApiRoutes;
using TGF.CA.Infrastructure.Communication.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP.HttpResult;

namespace Common.Infrastructure.Communication.HTTP
{
    public class MembersCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory) 
        : HttpCommunicationService(aServiceDiscovery, aHttpClientFactory), IMembersCommunicationService
    {
        private readonly string _serviceName = ServicesDiscoveryNames.Members;

        public async Task<IHttpResult<MemberDTO>> GetExistingMember(ulong aDiscordUserId, CancellationToken aCancellationToken = default)
        => await GetAsync<MemberDTO>(_serviceName, MembersApiRoutes.private_members_discordUserId.Replace("{discordUserId}", aDiscordUserId.ToString()), aCancellationToken);

        public async Task<IHttpResult<MemberDetailDTO>> SignUpNewMember(SignUpDataDTO? aSignUpDataDTO, DiscordCookieUserInfo aDiscordCookieUserInfo, CancellationToken aCancellationToken = default)
        => await PutAsync<CreateMemberDTO, MemberDetailDTO>(_serviceName, MembersApiRoutes.members, new CreateMemberDTO(aSignUpDataDTO, aDiscordCookieUserInfo), aCancellationToken);

        public async Task<IHttpResult<PermissionsEnum>> GetMemberPermissions(Guid aMemberId, CancellationToken aCancellationToken = default)
        => await GetAsync<PermissionsEnum>(_serviceName, MembersApiRoutes.private_members_permissions.Replace("{discordUserId}", aMemberId.ToString()), aCancellationToken);

    }
}
