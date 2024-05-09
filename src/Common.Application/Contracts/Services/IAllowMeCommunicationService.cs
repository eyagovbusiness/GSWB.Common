using Common.Application.DTOs.Discord;
using TGF.Common.ROP.HttpResult;

namespace Common.Application.Contracts.Services
{
    /// <summary>
    /// Provides services for communicating with the AllowMe warp service.
    /// </summary>
    public interface IAllowMeCommunicationService
    {
        /// <summary>
        /// Send to the allow me warp service an httprequest with the discord user Id to allow the access.
        /// </summary>
        /// <param name="aId"></param>
        /// <param name="aCancellationToken"></param>
        /// <returns></returns>
        public Task<IHttpResult<string>> AllowUser(string aId, CancellationToken aCancellationToken = default);

    }
}
