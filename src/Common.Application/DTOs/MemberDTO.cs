using Common.Domain.ValueObjects;
using Newtonsoft.Json;
using System.Collections.Immutable;

namespace Common.Application.DTOs
{
    public record MemberDTO(string DiscordGuildDisplayName, string? GameHandle, MemberStatusEnum Status, ImmutableArray<RoleDTO> Roles)
    {
        protected MemberDTO()
            : this("", null, default, ImmutableArray<RoleDTO>.Empty)
        {
        }

        [JsonConstructor]
        public MemberDTO(string aDiscordGuildDisplayName, string? aGameHandle, MemberStatusEnum aStatus, IEnumerable<RoleDTO> Roles)
        : this(aDiscordGuildDisplayName, aGameHandle, aStatus,
               Roles?.Where(r => r.Type != RoleTypesEnum.DiscordOnly).ToImmutableArray() ?? ImmutableArray<RoleDTO>.Empty)
        {
        }
    }
}
