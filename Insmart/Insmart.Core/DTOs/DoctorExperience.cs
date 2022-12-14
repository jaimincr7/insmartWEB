using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;

namespace Insmart.Core.DTOs
{
    [Table("doctor_experiences")]
    public class DoctorExperience : BaseEntity
    {
        public int DoctorExperienceId { get; set; }
        public int DoctorId { get; set; }
        public string HospitalName { get; set; } = null!;
        public string From { get; set; } = null!;
        public string? To { get; set; }
        public string Designation { get; set; } = null!;
        public bool IsCurrentWorking { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
