using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("doctors")]
    public class Doctor : BaseEntity
    {
        [Key]
        public int DoctorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhotoPath { get; set; }
        public string Email { get; set; }
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string LicenseNumber { get; set; }
        public string Degree { get; set; }
        public string Biography { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public int StateId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public int ApprovalStatus { get; set; }
        public string SignatureFilePath { get; set; }
        public string StampFilePath { get; set; }
        public decimal AverageRating { get; set; }
        public int TotalRatings { get; set; }
        public decimal YearsOfExperience { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
