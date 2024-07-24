using Common.Application.DTOs.Roles;
using Common.Domain.ValueObjects;
using System.Collections.Immutable;

namespace Common.Application.DTOs.Members
{
    public record MemberDetailDTO(
        Guid Id,
        string DiscordGuildDisplayName,
        string AvatarUrl,
        string? GameHandle,
        string? SpectrumCommunityMoniker,
        bool IsVerified,
        MemberStatusEnum Status,
        ImmutableArray<RoleDTO> Roles)
    : MemberDTO(Id, DiscordGuildDisplayName, GameHandle, Status, Roles);
}
