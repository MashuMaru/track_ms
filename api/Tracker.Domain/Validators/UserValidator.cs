using FluentValidation;
using Tracker.Domain.DTOs;

namespace Tracker.Domain.Validators;

public class UserValidator : AbstractValidator<UserDto>
{
    public UserValidator()
    {
        RuleFor(x => x.Username)
            .NotEmpty()
            .WithMessage("Username must not be empty and a maximum of 13 characters.")
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