namespace Common.Application.DTOs.Members
{
    public record MemberVerifyInfoDTO(bool IsVerified, string GameHandleVerifyCode, DateTimeOffset ExpiryDate);

}
