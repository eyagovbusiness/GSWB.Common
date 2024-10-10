﻿
namespace Common.Infrastructure.Communication.ApiRoutes
{
    public struct SwarmBotApiRoutes
    {
        public const string users_exist = "users/{id}/exist";
        public const string users_isVerified = "users/{id}/is-verified";
        public const string users_creationDate = "users/{id}/creation-date";
        public const string private_users_me_guilds = "private/users/me/guilds";

        public const string members_countOnline = "members/count-online";
        public const string members_profile = "members/{id}/profile";
        public const string guilds_members_roles = "guilds/{guildId}/members/{userId}/roles";

        public const string roles = "roles/{id}";
        public const string roles_assign = "roles/{id}/assign";
        public const string roles_revoke = "roles/{id}/revoke";

        public const string channels_categories = "channels/categories{id}";
        public const string channels_categories_byName = "channels/categories/by-name/{name}";
        public const string channels_categories_members = "channels/categories/{id}/members";

        public const string scTools_listShips = "sc-tools/ships";

        public const string private_testers = "private/testers/{id}";
        public const string private_guilds_id_roles = "private/guilds/{id}/roles";
    }

}
