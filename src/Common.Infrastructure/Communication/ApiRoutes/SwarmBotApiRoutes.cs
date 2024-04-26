
namespace Common.Infrastructure.Communication.ApiRoutes
{
    public struct SwarmBotApiRoutes
    {
        public const string users_exist = "users/{userId}/exist";
        public const string users_isVerified = "users/{userId}/is-verified";
        public const string users_creationDate = "users/{userId}/creation-date";

        public const string members_countOnline = "members/count-online";
        public const string members_profile = "members/{discordUserId}/profile";
        public const string members_roles = "members/{discordUserId}/roles";

        public const string roles = "roles";
        public const string roles_assign = "roles/{roleId}/assign";
        public const string roles_revoke = "roles/{roleId}/revoke";

        public const string channels_categories_byName = "channels/categories/by-name/{categoryName}";
        public const string channels_categories_members = "channels/categories/{categoryId}/members";
        public const string channels_categories = "channels/categories";

        public const string scTools_listShips = "scTools/ships";

        public const string testers = "testers/{discordUserId}";
    }

}
