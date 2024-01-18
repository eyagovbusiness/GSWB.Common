
namespace Common.Domain.ValueObjects
{
    /// <summary>
    /// Enum representing all the possible types of member roles.
    /// </summary>
    public enum RoleTypesEnum : byte
    {
        /// <summary>
        /// For roles having only a Discord purpose with no application permissions.
        /// </summary>
        DiscordOnly = 0,
        /// <summary>
        /// For roles having only an application purpose with application permissions.
        /// </summary>
        ApplicationRole = 1,
        /// <summary>
        /// For roles representing only the ownership of a given license with no application permissions. Certain License roles may be required to participate in certain events.
        /// </summary>
        License = 2
    }
}
