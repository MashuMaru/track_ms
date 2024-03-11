using FluentValidation;
using Tracker.Services.DTOs;

namespace Tracker.Services.Validator
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
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
}