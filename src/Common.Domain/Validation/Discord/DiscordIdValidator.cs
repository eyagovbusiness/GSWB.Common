using Common.Domain.Errors;
using FluentValidation;
using TGF.Common.ROP.Errors;

namespace Common.Domain.Validation
{
    public class DiscordIdValidator : AbstractValidator<string>
    {
        public DiscordIdValidator()
        {
            RuleFor(discordID => discordID)
                .NotNull()
                .NotEmpty()
                .Must(BeAValidDiscordId).WithROPError(DomainErrors.Validation.Discord.IdNotValid);
        }

        private bool BeAValidDiscordId(string discordId)
        => ulong.TryParse(discordId, out _);

    }
}
