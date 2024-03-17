using FluentValidation;
using Tracker.Domain.DTOs;

namespace Tracker.Domain.Validators;

public abstract class UserValidator : AbstractValidator<UserDto>
{
    protected UserValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty()
            .MaximumLength(13)
            .WithMessage("Username must be maximum 13 characters.");

        RuleFor(x => x.Email)
            .EmailAddress()
            .WithMessage("Email must be valid");

        RuleFor(x => x.Password)
            .MinimumLength(8)
            .WithMessage("Password must be between 8 and 13 characters.");
    }
}