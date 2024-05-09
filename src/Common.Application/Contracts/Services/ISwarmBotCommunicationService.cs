﻿using Common.Application.DTOs.Discord;
using TGF.Common.ROP.HttpResult;

namespace Common.Application.Contracts.Services
{
    /// <summary>
    /// Provides services for communicating with the SwarmBot API.
    /// </summary>
    public interface ISwarmBotCommunicationService
    {
        /// <summary>
        /// Gets a list of Discord user roles from the SwarmBot API.
        /// </summary>
        /// <param name="aDiscordUserId">The Discord user ID.</param>
        /// <param name="aCancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A result containing a list of Discord roles IF ANY, otherwise an HTTP error.</returns>
        Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordUserRoleList(string aDiscordUserId, CancellationToken aCancellationToken = default);

        /// <summary>
        /// Gets the discord member nickname in the guild's server via http request against the SwarmBot API.
        /// </summary>
        /// <param name="aDiscordUserId">The Discord user ID.</param>
        /// <param name="aCancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A result containing the discord member's profile <see cref="DiscordProfileDTO"/>, otherwise an HTTP error.</returns>
        Task<IHttpResult<DiscordProfileDTO>> GetMemberProfileFromId(string aDiscordUserId, CancellationToken aCancellationToken = default);

        /// <summary>
        /// Fetches the list of all guild server roles from Discord.
        /// </summary>
        /// <returns>List of roles from Discord's server.</returns>
        Task<IHttpResult<IEnumerable<DiscordRoleDTO>>> GetDiscordRoleList(CancellationToken aCancellationToken = default);

        /// <summary>
        /// Fetches if a given discord user Id has the tester role in the GuildSwarm Discord server.
        /// </summary>
        /// <param name="aId">the dicscord user ID</param>
        /// <param name="aCancellationToken"></param>
        /// <returns>The discord user Id and 200 Success if it is a tester or 404 Error if no member with that id was found with the role tester.</returns>
        public Task<IHttpResult<string>> GetIsTester(string aId, CancellationToken aCancellationToken = default);


    }
}
