namespace Common.Application.Communication.Routing
{
    public struct MembersApiRoutes
    {
        #region MeEndpoints
        public const string members_me = "members/me";
        public const string members_me_guilds = "members/me/guilds";
        public const string members_me_guild = "members/me/guild";
        public const string members_me_verify = "members/me/verify";
        #endregion

        #region MembersEndpoints
        public const string guilds_mine_members = "guilds/mine/members";
        public const string guilds_mine_members_getByIds = "guilds/mine/members/get-by-ids";
        public const string guilds_mine_members_count = "guilds/mine/members/count";
        #endregion

        #region RoleEndpoints
        public const string guilds_mine_roles = "guilds/mine/roles";
        #endregion

        #region PrivateEndpoints
        public const string private_members = "private/members";//needs guild id in the route
        public const string private_members_key = "private/guilds/{guildId}/members/{userId}";
        public const string private_members_permissions = "private/guilds/{guildId}/members/{userId}/permissions";
        #endregion

    }
}
