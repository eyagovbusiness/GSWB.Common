namespace Common.Domain.ValueObjects
{
    /// <summary>
    /// Static class that defines the available roles for this application.
    /// </summary>
    public static class ApplicationRoles
    {
        /// <summary>
        /// The role name for the administrator members.
        /// </summary>
        public const string Admin = "Admin";

        /// <summary>
        /// The role name for highly trusted guild members that currently play in administrative roles with responsibility.
        /// Only "Daga" members are elegible for this role.
        /// </summary>
        public const string Espada = "Espada";

        /// <summary>
        /// The role name for trusted guild members who have voice and can vote about the guild matters after passing the testing peroid as "Cadete".
        /// </summary>
        public const string Daga = "Daga";

        /// <summary>
        /// The role name for affiliate guild members who want to get involved more closely into the guild and applied to "Daga" and they are in a testing period.
        /// </summary>
        public const string Cadete = "Cadete";

        /// <summary>
        /// The role name for affiliate guild members without any close vinculation to the guild.
        /// </summary>
        public const string Afiliado = "Afiliado";

        /// <summary>
        /// The role name for recently joined affiliate guild members without any close vinculation to the guild.
        /// </summary>
        public const string NuevoAfiliado = "Afiliado*";

    }
}