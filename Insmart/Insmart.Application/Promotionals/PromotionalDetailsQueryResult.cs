using Insmart.Application.Doctors;
using Insmart.Application.Hospitals;
using Insmart.Core.DTOs;

namespace Insmart.Application.Promotionals
{
    public class PromotionalDetailsQueryResult
    {
        public int PromotionalId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PromotionalType { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public DoctorNamesListQueryResult Doctors { get; set; }
        public HospitalListQueryResult Hospitals { get; set; }
        public IEnumerable<Symptom> Symptoms { get; set; }
        public IEnumerable<Speciality> Specialities { get; set; }
    }
}
