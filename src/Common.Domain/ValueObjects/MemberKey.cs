
using System.ComponentModel.DataAnnotations;

namespace Common.Domain.ValueObjects
{
    public record MemberKey([property: Required] ulong GuildId, [property: Required] ulong UserId)
    {
        // Additional constructor to accept string parameters
        public MemberKey([param: Required] string guildId, [param: Required] string userId)
            : this(ConvertToUlong(guildId), ConvertToUlong(userId))
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
