using Common.Application.DTOs.Auth;
using Common.Application.DTOs.Members;
using Common.Domain.ValueObjects;
using TGF.Common.ROP.HttpResult;

namespace Common.Application.Contracts.Services
{
    /// <summary>
    /// Provides services for communicating with the Members API.
    /// </summary>
    public interface IMembersCommunicationService
    {

        Task<IHttpResult<MemberDetailDTO>> GetExistingMember(MemberKey memberKey, CancellationToken aCancellationToken = default);

        Task<IHttpResult<IEnumerable<MemberDetailDTO>>> GetMembersByIdList(IEnumerable<MemberKey> aMemberKeyList, string aAccessToken, CancellationToken aCancellationToken = default);

        Task<IHttpResult<MemberDetailDTO>> SignUpNewMember(SignUpDataDTO? aSignUpDataDTO, DiscordCookieUserInfo aDiscordCookieUserInfo, string guildId, CancellationToken aCancellationToken = default);

        /// <summary>
        /// Gets the member's permissions via http request against the Members API.
        /// </summary>
        /// <param name="memberKey">The Member composite key.</param>
        /// <param name="aCancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>An int enum flags containing the member's permissions <see cref="PermissionsEnum"/>, otherwise an HTTP error.</returns>
        Task<IHttpResult<PermissionsEnum>> GetMemberPermissions(MemberKey memberKey, CancellationToken aCancellationToken = default);

    }
}
