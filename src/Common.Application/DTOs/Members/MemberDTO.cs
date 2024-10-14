using Common.Application.DTOs.Roles;
using Common.Domain.ValueObjects;
using Newtonsoft.Json;
using System.Collections.Immutable;

namespace Common.Application.DTOs.Members
{
    public record MemberDTO(Guid Id, string GuildId, string DiscordGuildDisplayName, string? GameHandle, MemberStatusEnum Status, ImmutableArray<RoleDTO> Roles);
}
