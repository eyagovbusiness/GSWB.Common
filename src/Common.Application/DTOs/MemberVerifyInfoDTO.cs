
namespace Common.Application.DTOs
{
    public record MemberVerifyInfoDTO(bool IsVerified, string GameHandleVerifyCode, DateTimeOffset ExpiryDate);

}
