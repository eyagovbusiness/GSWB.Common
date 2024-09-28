
namespace SwarmBot.Infrastructure.Communication
{
    public static class RoutingKeys
    {
        public static class SwarmBot
        {
            public const string SwarmBot_Members_sync = "swarm-bot.members.sync";
            public const string SwarmBot_Roles_sync = "swarm-bot.roles.sync";
        }
        public static class Members
        {
            public const string Member_revoke = "member.revoke";
            public const string Member_role_revoke = "member.roles.revoke";
        }
        public static class Guilds
        {
            public const string Guilds_sync = "guilds.sync";
        }
    }
}
