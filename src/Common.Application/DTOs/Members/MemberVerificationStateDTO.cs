namespace Common.Application.DTOs.Members
{
    public record MemberVerificationStateDTO(bool IsVerified, string GameHandleVerifyCode, DateTimeOffset ExpiryDate);

}
