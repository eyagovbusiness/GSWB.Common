using Common.Application;
using Common.Application.DTOs.Discord;
using Mandril.Application;
using TGF.CA.Infrastructure.Communication.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP.HttpResult;


namespace Common.Infrastructure.Communication.HTTP
{
    /// <summary>
    /// Provides services for communicating with the Mandrill API.
    /// </summary>
    public class MandrillCommunicationService : HttpCommunicationService, IMandrillCommunicationService
    {
        private readonly string _serviceName;

        public MandrillCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory)
        : base(aServiceDiscovery, aHttpClientFactory)
            => _serviceName = ServicesDiscoveryNames.Mandrill;

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordUserRoleList(string aDiscordUserId, CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, $"{MandrilApiRoutes.members_roles}?discordUserId={aDiscordUserId}", aCancellationToken);

        public async Task<IHttpResult<DiscordProfileDTO>> GetMemberProfileFromId(string aDiscordUserId, CancellationToken aCancellationToken = default)
            => await GetAsync<DiscordProfileDTO>(_serviceName, $"{MandrilApiRoutes.members_profile}?discordUserId={aDiscordUserId}", aCancellationToken);

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordRoleList(CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, MandrilApiRoutes.roles_serverRoles, aCancellationToken);

    }
}
