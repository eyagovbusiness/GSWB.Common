using TGF.Common.ROP.Errors;

namespace Common.Domain.Errors
{
    public static partial class DomainErrors
    {
        public static partial class Validation
        {
            public static class Discord
            {
                public static Error IdNotValid => new(
                    "Validation.Discord.IdNotValid",
                    "The provided string cannot be parsed to a valid discord Id."
                );
            }
        }
    }
}
