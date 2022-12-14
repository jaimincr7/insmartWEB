using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace Insmart.Core.DTOs
{
    [Table("doctor_clinics")]
    public class DoctorClinic : BaseEntity
    {
        public int DoctorClinicId { get; set; }
        public int DoctorId { get; set; }
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
        public int PhoneCode { get; set; }
        public string MobileNumber { get; set; } = null!;
        public string? EmergencyMobileNumber { get; set; }
        public string Email { get; set; } = null!;
        public string LicenseNumber { get; set; } = null!;
        public string? Aboutus { get; set; }
        public string Address { get; set; } = null!;
        public string? Ward { get; set; }
        public string District { get; set; } = null!;
        public string City { get; set; } = null!;
        public int StateId { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
