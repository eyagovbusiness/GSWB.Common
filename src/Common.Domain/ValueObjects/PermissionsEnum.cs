
namespace Common.Domain.ValueObjects
{
    /// <summary>
    /// Each bit represents one permission type(excluding the sign bit).
    /// </summary>
    [Flags]
    public enum PermissionsEnum
    {
        None = 0,
        /// <summary>
        /// Can participate in the events.
        /// </summary>
        AccessEvents = 1,
        /// <summary>
        /// Can create and manage events.
        /// </summary>
        ManageEvents = 1 << 1,// 2^1 =2
        /// <summary>
        /// Can accept external in-game service requests.
        /// </summary>
        AcceptServiceRequests = 1 << 2, // 2^2 = 4
        /// <summary>
        /// Can visualize the internal diplomacy information.
        /// </summary>
        AccessDiplomacy = 1 << 3, // 2^3 = 8
        /// <summary>
        /// Can manage the diplomacy and access the secret diplomacy.
        /// </summary>
        EditDiplomacy = 1 << 4,
        /// <summary>
        /// Can apply for licenses and own licenses.
        /// </summary>
        AccessLicenses = 1 << 5,
        /// <summary>
        /// Can create licenses and validate requirements.
        /// </summary>
        EditLicenses = 1 << 6,
        /// <summary>
        /// Can create incident reports and can view sentences.
        /// </summary>
        AccessLawSystem = 1 << 7,
        /// <summary>
        /// Can view all incident reports and can create sentences.
        /// </summary>
        ManageLawSystem = 1 << 8,
        /// <summary>
        /// Access the members list and overall members information.
        /// </summary>
        AccessMembers = 1 << 9,
        /// <summary>
        /// Can access and do everything.
        /// </summary>
        Admin = 0x7FFFFFFF

    }
}
