using Common.Application.DTOs.Members;

namespace Common.Application.DTOs.Events
{
    public record EventManagerDetailDTO(MemberDetailDTO Member, string? Logbook);
}
