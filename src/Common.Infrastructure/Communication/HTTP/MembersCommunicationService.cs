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

        public async Task<IHttpResult<MemberDTO>> GetExistingMember(ulong aId, CancellationToken aCancellationToken = default)
        => await GetAsync<MemberDTO>(_serviceName, MembersApiRoutes.private_members_discordUserId.Replace("{id}", aId.ToString()), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<IEnumerable<MemberDetailDTO>>> GetMembersByIdList(IEnumerable<Guid> aMemberIdList, string aAccessToken, CancellationToken aCancellationToken = default)
        => await PostAsync<IEnumerable<Guid>,IEnumerable<MemberDetailDTO>>(_serviceName, MembersApiRoutes.members_getByIds, aMemberIdList, aAccessToken, aCancellationToken);


        public async Task<IHttpResult<MemberDetailDTO>> SignUpNewMember(SignUpDataDTO? aSignUpDataDTO, DiscordCookieUserInfo aDiscordCookieUserInfo, CancellationToken aCancellationToken = default)
        => await PutAsync<CreateMemberDTO, MemberDetailDTO>(_serviceName, MembersApiRoutes.private_members, new CreateMemberDTO(aSignUpDataDTO, aDiscordCookieUserInfo), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<PermissionsEnum>> GetMemberPermissions(Guid aId, CancellationToken aCancellationToken = default)
        => await GetAsync<PermissionsEnum>(_serviceName, MembersApiRoutes.private_members_permissions.Replace("{id}", aId.ToString()), aCancellationToken: aCancellationToken);

    }
}
