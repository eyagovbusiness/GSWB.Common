using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.Events
{
    public record EventManagersDTO(Guid EventId, IEnumerable<MemberKey> MemberKeyList);
}
