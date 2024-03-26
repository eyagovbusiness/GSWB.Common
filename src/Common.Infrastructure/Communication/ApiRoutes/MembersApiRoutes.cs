namespace Common.Infrastructure.Communication.ApiRoutes
{
    public struct MembersApiRoutes
    {
        #region MeEndpoints
        public const string members_me = "members/me";
        public const string members_me_update = "members/me/update";
        public const string members_me_delete = "members/me/delete";
        public const string members_me_getVerifyInfo = "members/me/getVerifyInfo";
        public const string members_me_refreshVerifyCode = "members/me/refreshVerifyCode";
        public const string members_me_verifyGameHandle = "members/me/verifyGameHandle";
        #endregion

        #region MembersEndpoints
        public const string members_list = "members/list";
        public const string members_count = "members/count";
        #endregion

        #region PrivateEndpoints
        public const string private_members_getByDiscordUserId = "private/members/getByDiscordUserId";
        public const string private_members_addNew = "private/members/addNew";
        public const string private_members_update = "private/members/update";
        #endregion

        #region RoleEndpoints
        public const string roles_syncRolesWithDiscord = "roles/syncRolesWithDiscord";
        public const string roles_getRoles = "roles/getRoles";
        public const string roles_update = "roles/update";
        #endregion


    }
}
