using Common.Application.Communication.Routing;
using Common.Application.Contracts.Services;
using Common.Application.DTOs.Auth;
using Common.Application.DTOs.Members;
using Common.Domain.ValueObjects;
using TGF.CA.Application.DTOs;
using TGF.CA.Infrastructure.Communication.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP.HttpResult;

namespace Common.Infrastructure.Communication.HTTP
{
    public class MembersCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory) 
        : HttpCommunicationService(aServiceDiscovery, aHttpClientFactory), IMembersCommunicationService
    {
        private readonly string _serviceName = ServicesDiscoveryNames.Members;

        public async Task<IHttpResult<MemberDTO>> GetExistingMember(Guid id, CancellationToken aCancellationToken = default)
        => await GetAsync<MemberDTO>(_serviceName, MembersApiRoutes.private_members_id.Replace("{id}", id.ToString()), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<MemberDetailDTO>> GetExistingMember(string userId, string guildId, CancellationToken aCancellationToken = default)
        => await GetAsync<MemberDetailDTO>(_serviceName, MembersApiRoutes.private_members_userId_guildId.Replace("{userId}", userId).Replace("{guildId}", guildId), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<IEnumerable<MemberDetailDTO>>> GetMembersByIdList(IEnumerable<Guid> aMemberIdList, string aAccessToken, CancellationToken aCancellationToken = default)
        => await PostAsync<IEnumerable<Guid>,IEnumerable<MemberDetailDTO>>(_serviceName, MembersApiRoutes.members_getByIds, aMemberIdList, [new(AuthenticationForwardingType.JWT, aAccessToken)], aCancellationToken);


        public async Task<IHttpResult<MemberDetailDTO>> SignUpNewMember(SignUpDataDTO? aSignUpDataDTO, DiscordCookieUserInfo aDiscordCookieUserInfo, string guildId, CancellationToken aCancellationToken = default)
        => await PutAsync<CreateMemberDTO, MemberDetailDTO>(_serviceName, MembersApiRoutes.private_members, new CreateMemberDTO(aSignUpDataDTO, aDiscordCookieUserInfo, guildId), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<PermissionsEnum>> GetMemberPermissions(Guid aId, CancellationToken aCancellationToken = default)
        => await GetAsync<PermissionsEnum>(_serviceName, MembersApiRoutes.private_members_permissions.Replace("{id}", aId.ToString()), aCancellationToken: aCancellationToken);

    }
}
