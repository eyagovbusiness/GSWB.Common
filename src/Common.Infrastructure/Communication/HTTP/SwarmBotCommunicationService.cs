using Common.Application.Contracts.Services;
using Common.Application.DTOs.Discord;
using Common.Infrastructure.Communication.ApiRoutes;
using TGF.CA.Infrastructure.Communication.Http;
using TGF.CA.Infrastructure.Discovery;
using TGF.Common.ROP.HttpResult;


namespace Common.Infrastructure.Communication.HTTP
{
    /// <summary>
    /// Provides services for communicating with the SwarmBot API.
    /// </summary>
    public class SwarmBotCommunicationService : HttpCommunicationService, ISwarmBotCommunicationService
    {
        private readonly string _serviceName;

        public SwarmBotCommunicationService(IServiceDiscovery aServiceDiscovery, IHttpClientFactory aHttpClientFactory)
        : base(aServiceDiscovery, aHttpClientFactory)
            => _serviceName = ServicesDiscoveryNames.SwarmBot;

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordUserRoleList(string aDiscordUserId, CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, $"{SwarmBotApiRoutes.members_roles}?discordUserId={aDiscordUserId}", aCancellationToken);

        public async Task<IHttpResult<DiscordProfileDTO>> GetMemberProfileFromId(string aDiscordUserId, CancellationToken aCancellationToken = default)
            => await GetAsync<DiscordProfileDTO>(_serviceName, $"{SwarmBotApiRoutes.members_profile}?discordUserId={aDiscordUserId}", aCancellationToken);

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordRoleList(CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, SwarmBotApiRoutes.roles_serverRoles, aCancellationToken);

    }
}
