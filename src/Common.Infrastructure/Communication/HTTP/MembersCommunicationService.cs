using Common.Application.Communication.Routing;
using Common.Application.Contracts.Services;
using Common.Application.DTOs.Auth;
using Common.Application.DTOs.Members;
using Common.Domain.ValueObjects;
using TGF.CA.Application.DTOs;
using TGF.CA.Infrastructure.Comm.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP.HttpResult;

namespace Common.Infrastructure.Communication.HTTP
{
    public class MembersCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory) 
        : HttpCommunicationService(aServiceDiscovery, aHttpClientFactory), IMembersCommunicationService
    {
        private readonly string _serviceName = ServicesDiscoveryNames.Members;

        public async Task<IHttpResult<MemberDetailDTO>> GetExistingMember(MemberKey memberKey, CancellationToken aCancellationToken = default)
        => await GetAsync<MemberDetailDTO>(
            _serviceName,
            MembersApiRoutes.private_members_key
                .Replace("{guildId}", memberKey.GuildId.ToString())
                .Replace("{userId}", memberKey.UserId.ToString()),
            aCancellationToken: aCancellationToken
        );

        public async Task<IHttpResult<IEnumerable<MemberDetailDTO>>> GetMembersByIdList(IEnumerable<MemberKey> aMemberKeyList, string aAccessToken, CancellationToken aCancellationToken = default)
        => await PostAsync<IEnumerable<MemberKey>,IEnumerable<MemberDetailDTO>>(_serviceName, MembersApiRoutes.guilds_mine_members_getByIds, aMemberKeyList, [new(AuthenticationForwardingType.JWT, aAccessToken)], aCancellationToken);

        public async Task<IHttpResult<MemberDetailDTO>> SignUpNewMember(SignUpDataDTO? aSignUpDataDTO, DiscordCookieUserInfo aDiscordCookieUserInfo, string guildId, CancellationToken aCancellationToken = default)
        => await PutAsync<CreateMemberDTO, MemberDetailDTO>(_serviceName, MembersApiRoutes.private_members, new CreateMemberDTO(aSignUpDataDTO, aDiscordCookieUserInfo, guildId), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<PermissionsEnum>> GetMemberPermissions(MemberKey memberKey, CancellationToken aCancellationToken = default)
        => await GetAsync<PermissionsEnum>(
            _serviceName,
            MembersApiRoutes.private_members_permissions
                .Replace("{guildId}", memberKey.GuildId.ToString())
                .Replace("{userId}", memberKey.UserId.ToString()),
            aCancellationToken: aCancellationToken
        );

    }
}
