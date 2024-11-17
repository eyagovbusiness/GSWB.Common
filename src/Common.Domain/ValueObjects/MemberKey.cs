using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Common.Domain.ValueObjects
{
    public record MemberKey
    {
        [Required]
        public ulong GuildId { get; init; }

        [Required]
        public ulong UserId { get; init; }

        // Constructor that accepts ulong parameters
        [JsonConstructor]
        public MemberKey(ulong guildId, ulong userId)
        {
            GuildId = guildId;
            UserId = userId;
        }

        // Constructor that accepts string parameters
        public MemberKey(string guildId, string userId)
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
