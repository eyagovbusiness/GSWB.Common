using Common.Application.Contracts.Services;
using Common.Application.DTOs.Discord;
using Common.Application.DTOs.Guilds;
using Common.Infrastructure.Communication.ApiRoutes;
using TGF.CA.Application.DTOs;
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

        public async Task<IHttpResult<IEnumerable<GuildDTO>>> GetUserGuildList(string id, CancellationToken cancellationToken = default)
            => await GetAsync<IEnumerable<GuildDTO>>(_serviceName, SwarmBotApiRoutes.private_users_me_guilds.Replace("{id}", id), aCancellationToken: cancellationToken);

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetMemberRoleList(string guildId, string userId, CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, SwarmBotApiRoutes.private_guilds_members_roles.Replace("{guildId}", guildId).Replace("{userId}", userId), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<DiscordProfileDTO>> GetMemberProfileFromId(string guildId, string userId, CancellationToken aCancellationToken = default)
            => await GetAsync<DiscordProfileDTO>(_serviceName, SwarmBotApiRoutes.private_currentGuild_members_profile.Replace("{guildId}", guildId.ToString()).Replace("{userId}", userId.ToString()), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetGuildDiscordRoleList(string guildId, CancellationToken aCancellationToken = default)
            => await GetAsync<IEnumerable<DiscordRoleDTO>>(_serviceName, SwarmBotApiRoutes.private_guilds_roles.Replace("{guildId}", guildId), aCancellationToken: aCancellationToken);

        public async Task<IHttpResult<string>> GetIsTester(string guildId, string userId, CancellationToken aCancellationToken = default)
            => await GetAsync<string>(_serviceName, SwarmBotApiRoutes.private_guilds_testers.Replace("{guildId}", guildId).Replace("{userId}", userId.ToString()), aCancellationToken: aCancellationToken);

    }
}
