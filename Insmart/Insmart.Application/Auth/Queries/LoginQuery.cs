using FluentValidation;
using Insmart.Application.Features.Auth.Results;
using MediatR;

namespace Insmart.Application.Features.Auth.Queries
{
    public class LoginQuery: IRequest<LoginQueryResult>
    {
        public string UserName { get; set; } = null!;
        public string Password { get; set; } = null!;
    }

    public class LoginQueryValidator : AbstractValidator<LoginQuery>
    {
        public LoginQueryValidator()
        {
            RuleFor(t => t.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(t => t.Password).NotEmpty().WithMessage("Password is required");
        }
    }
}
