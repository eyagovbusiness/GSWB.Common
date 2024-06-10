using Common.Application.DTOs.Roles;
using Common.Domain.ValueObjects;
using Newtonsoft.Json;
using System.Collections.Immutable;

namespace Common.Application.DTOs.Members
{
    public record MemberDTO(Guid Id, string DiscordGuildDisplayName, string? GameHandle, MemberStatusEnum Status, ImmutableArray<RoleDTO> Roles)
    {
        protected MemberDTO()
            : this(default, "", null, default, [])
        {
        }

        [JsonConstructor]
        public MemberDTO(Guid Id, string aDiscordGuildDisplayName, string? aGameHandle, MemberStatusEnum aStatus, IEnumerable<RoleDTO> Roles)
        : this(Id, aDiscordGuildDisplayName, aGameHandle, aStatus,
               Roles?.Where(r => r.Type != RoleTypesEnum.DiscordOnly).ToImmutableArray() ?? [])
        {
        }
    }
}
