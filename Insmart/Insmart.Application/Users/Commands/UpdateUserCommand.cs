using Insmart.Application.Models;
using MediatR;

namespace Insmart.Application.Users.Commands
{
    public class UpdateUserCommand : UpdateCommand, IRequest<bool>
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
    }
}
