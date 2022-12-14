namespace Insmart.Application.Hospitals
{
    public class HospitalDetailsQueryResult 
    {
        public int HospitalId { get; set; }
        public int DoctorCount { get; set; }
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
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }

        public string ImagePath { get; set; }
        public string City { get; set; }
    }
}
