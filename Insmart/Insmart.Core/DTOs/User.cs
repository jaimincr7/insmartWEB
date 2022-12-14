using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("users")]
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; } = null!;
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string UserName { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string? UniqueId { get; set; }
        public string? ZaloNumber { get; set; }
        public string? FacebookId { get; set; }
        public string? GoogleId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
