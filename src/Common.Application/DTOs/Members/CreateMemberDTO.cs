using Common.Application.DTOs.Auth;

namespace Common.Application.DTOs.Members
{
    public record CreateMemberDTO(SignUpDataDTO? SignUpData, DiscordCookieUserInfo DiscordCookieUserInfo, string guildId);
}
