namespace Common.Application.Communication.Routing
{
    public struct SwarmBotApiRoutes
    {
        public const string users_exist = "users/{id}/exist";
        public const string users_isVerified = "users/{id}/is-verified";
        public const string users_creationDate = "users/{id}/creation-date";
        public const string private_users_me_guilds = "private/users/{id}/guilds";

        public const string private_guilds_members_countOnline = "private/guilds/{guildId}/members/count-online";
        public const string private_currentGuild_members_profile = "private/{guildId}/members/{userId}/profile";
        public const string private_guilds_members_roles = "private/guilds/{guildId}/members/{userId}/roles";

        public const string private_guilds_roles = "private/guilds/{guildId}/roles";
        public const string private_guilds_roles_createGuildSwarmAdmin = "private/guilds/{guildId}/roles/create-guildswarm-admin";
        public const string private_guilds_roles_name = "private/guilds/{guildId}/roles/{name}";
        public const string private_guilds_role = "private/guilds/{guildId}/roles/{roleId}";
        public const string private_roles_assign = "private/guilds/{guildId}/roles/{roleId}/assign";
        public const string private_roles_revoke = "private/guilds/{guildId}/roles/{roleId}/revoke";


        public const string private_channels_categories = "private/channels/categories/{id}";
        public const string private_channels_categories_byName = "private/channels/categories/by-name/{name}";
        public const string private_channels_categories_members = "private/channels/categories/{id}/members";

        public const string scTools_listShips = "sc-tools/ships";

        public const string private_guilds_testers = "private/guilds/{guildId}/testers/{userId}";

    }

}
