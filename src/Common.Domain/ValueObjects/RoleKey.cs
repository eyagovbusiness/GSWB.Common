using System.ComponentModel.DataAnnotations;

namespace Common.Domain.ValueObjects
{

    public record RoleKey([property: Required] ulong GuildId, [property: Required] ulong RoleId)
    {
        // Additional constructor to accept string parameters
        public RoleKey([param: Required] string guildId, [param: Required] string roleId)
            : this(ConvertToUlong(guildId), ConvertToUlong(roleId))
        {
        }

        // Helper method to convert strings to ulong
        private static ulong ConvertToUlong(string value)
        {
            if (!ulong.TryParse(value, out var result))
                throw new ArgumentException($"Invalid ulong value: {value}");
            return result;
        }
    }
}
