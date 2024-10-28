using Common.Application.DTOs.Roles;
using Common.Domain.ValueObjects;
using System.Collections.Immutable;

namespace Common.Application.DTOs.Members
{
    /// <summary>
    /// Detail DTO for Member entitiy including <see cref="RoleDTO"/> list and additional member properties not present in the basic <see cref="MemberDTO"/>.
    /// </summary>
    public record MemberDetailDTO(
        Guid Id,
        string GuildId,
        string DiscordGuildDisplayName,
        string AvatarUrl,
        string? GameHandle,
        string? SpectrumCommunityMoniker,
        bool IsVerified,
        MemberStatusEnum Status,
        ImmutableArray<RoleDTO> Roles);
}
