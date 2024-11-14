using Common.Domain.ValueObjects;
using System.Collections.Immutable;

namespace Common.Application.DTOs.Members
{
    public record MemberDTO(
        string UserId,
        string GuildId,
        string DiscordGuildDisplayName,
        string DiscordAvatarUrl,
        string? GameHandle,
        MemberStatusEnum Status,
        ImmutableArray<string> Roles);
}
