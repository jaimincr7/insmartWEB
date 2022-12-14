using FluentValidation;
using Insmart.Application.Models;
using MediatR;
using System.Text.Json.Serialization;

namespace Insmart.Application.Users.Commands
{
    public class CreateUserCommand : CreateCommand, IRequest<int>
    {
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string UserName { get; set; } = null!;
        public string? UniqueId { get; set; }
        public string? ZaloNumber { get; set; }
        public string? FacebookId { get; set; }
        public string? GoogleId { get; set; }
        public string PasswordHash { get; set; } = string.Empty;


        [JsonIgnore]
        public bool IsActive { get; set; } = true;
    }

    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(t => t.FullName).NotEmpty();
            RuleFor(t => t.MobileNumber).NotEmpty();
            RuleFor(t => t.Email).NotEmpty();
            RuleFor(t => t.UniqueId).NotEmpty();
            RuleFor(t => t.PasswordHash).NotEmpty();
        }
    }
}
