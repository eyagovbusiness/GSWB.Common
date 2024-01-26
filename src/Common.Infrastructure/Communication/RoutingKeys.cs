using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
