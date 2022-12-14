using Insmart.Application.Models;
using MediatR;
using System.Text.Json.Serialization;

namespace Insmart.Application.Users.Commands
{
    public class CreateUserAddressCommand : CreateCommand, IRequest<int>
    {
        public int UserAddressId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Ward { get; set; } = null!;
        public string District { get; set; } = null!;
        public int StateId { get; set; }
        public int CityId { get; set; }
        public bool IsDefaultAddress { get; set; }
        [JsonIgnore]
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
