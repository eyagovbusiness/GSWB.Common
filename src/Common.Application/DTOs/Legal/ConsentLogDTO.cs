
using Common.Domain.ValueObjects;

namespace Common.Application.DTOs.Legal
{
    public record ConsentLogDTO(ConsentTypeEnum ConsentType, string PrivacyPolicyVersion, ConsentMethodEnum ConsentMethod, string? UserAgent, string? Geolocation);
}
