using Dapper.Contrib.Extensions;
using System;

namespace Insmart.Core.DTOs
{
    [Table("patients")]
    public class Patient : BaseEntity
    {
        [Key]
        public long PatientId { get; set; }
        public string FullName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; }
        public int RelationId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public int UserId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
