using Common.Domain.ValueObjects;
using System.Collections.Immutable;

namespace Common.Application.DTOs
{
    public record MemberDetailDTO(
        string DiscordGuildDisplayName,
        string AvatarUrl,
        string? GameHandle,
        string? SpectrumCommunityMoniker,
        bool IsVerified,
        MemberStatusEnum Status,
        ImmutableArray<RoleDTO> Roles)
    : MemberDTO(DiscordGuildDisplayName, GameHandle, Status, Roles);
}
