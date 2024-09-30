namespace Common.Infrastructure.Communication.ApiRoutes
{
    public struct APIGatewayApiRoutes
    {
        public struct Auth_signIn
        {
            public const string Route = "auth/sign-in";
            public const string OperationId = "auth_sign-in";
        }
        public struct Auth_testerSignIn
        {
            public const string Route = "auth/tester-sign-in";
            public const string OperationId = "auth_tester-sign-in";
        }

        public struct Auth_signUp
        {
            public const string Route = "auth/sign-up";
            public const string OperationId = "auth_sign-up";
        }

        public struct Auth_signOut
        {
            public const string Route = "auth/sign-out";
            public const string OperationId = "auth_sign-out";
        }

        public struct Auth_token_guildId
        {
            public const string Route = "auth/token/{guildId}";
            public const string OperationId = "auth_token_gildId";
        }

        public struct Auth_token_refresh
        {
            public const string Route = "auth/token/refresh";
            public const string OperationId = "auth_token_refresh";
        }

        public struct Legal_consent
        {
            public const string Route = "legal/consent";
            public const string OperationId = "legal_consent";
        }
    }
}
