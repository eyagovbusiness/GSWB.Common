namespace Common.Application.DTOs.Auth
{
    /// <summary>
    /// Represents the claims defined in the discord cookie.
    /// </summary>
    /// <param name="UserNameIdentifier">Discord user Id.</param>
    /// <param name="UserName">Discord username.</param>
    /// <param name="GivenName">Discord display name.</param>
    public record DiscordCookieUserInfo(string UserNameIdentifier, string UserName, string GivenName);//TO-DO: GSWB-27
}
