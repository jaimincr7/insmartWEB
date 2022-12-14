using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("hospitals")]
    public class Hospital : BaseEntity
    {
        [Key]
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; }
        public string EmergencyMobileNumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Aboutus { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int IsInsuranceApplicable { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
