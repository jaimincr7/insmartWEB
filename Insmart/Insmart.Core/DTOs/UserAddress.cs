using Dapper.Contrib.Extensions;
using System.Net;

namespace Insmart.Core.DTOs
{
    [Table("user_addresses")]
    public class UserAddress : BaseEntity
    {
        [Key]
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
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

    }
}
