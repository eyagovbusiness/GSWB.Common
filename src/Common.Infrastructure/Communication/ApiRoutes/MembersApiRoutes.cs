namespace Common.Infrastructure.Communication.ApiRoutes
{
    public struct MembersApiRoutes
    {
        #region MeEndpoints
        public const string members_me = "members/me";
        public const string members_me_verify = "members/me/verify";
        #endregion

        #region MembersEndpoints
        public const string members = "members";
        public const string members_count = "members/count";
        #endregion

        #region PrivateEndpoints
        public const string private_members = "private/members";
        public const string private_members_discordUserId = "private/members/{id}";
        public const string private_members_permissions = "private/members/{id}/permissions";
        #endregion

        #region RoleEndpoints
        public const string roles_discordSync = "roles/discord-sync";
        public const string roles = "roles";
        #endregion

    }
}
