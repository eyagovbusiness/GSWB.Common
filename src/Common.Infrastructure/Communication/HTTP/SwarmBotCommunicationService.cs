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

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordUserRoleList(string aId, CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, SwarmBotApiRoutes.members_roles.Replace("{id}", aId.ToString()), aCancellationToken);

        public async Task<IHttpResult<DiscordProfileDTO>> GetMemberProfileFromId(string aId, CancellationToken aCancellationToken = default)
            => await GetAsync<DiscordProfileDTO>(_serviceName, SwarmBotApiRoutes.members_profile.Replace("{id}", aId.ToString()), aCancellationToken);

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordRoleList(CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, SwarmBotApiRoutes.roles, aCancellationToken);

        public async Task<IHttpResult<string>> GetIsTester(string aId, CancellationToken aCancellationToken = default)
            => await GetAsync<string>(_serviceName, SwarmBotApiRoutes.private_testers.Replace("{id}", aId.ToString()), aCancellationToken);

    }
}
