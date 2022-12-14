using Insmart.Application.Doctors.Queries;
using Insmart.Application.Doctors;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        Task<DoctorNamesListQueryResult> GetAllPromotionalAsync(int promotionlId);

        Task<DoctorNamesListQueryResult> GetHomePageDoctorsAsync(DoctorNamesListQuery request);

        Task<DoctorListingQueryResult> GetDoctorListAsync(DoctorListQuery request);

        Task<DoctorDetailsQueryResult> GetDoctorDetailsAsync(int doctorId);

        Task<IEnumerable<Language>> GetDoctorLanguagesAsync(int doctorId);

        Task<IEnumerable<Speciality>> GetDoctorSpecialitiesAsync(int doctorId);

        Task<IEnumerable<DoctorEducation>> GetDoctorEducationsAsync(int doctorId);

        Task<IEnumerable<DoctorAward>> GetDoctorAwardsAsync(int doctorId);

        Task<IEnumerable<AppointmentReview>> GetDoctorPatientFeedbackAsync(int doctorId);

        Task<IEnumerable<Hospital>> GetDoctorHospitalsAsync(int doctorId);

        Task<IEnumerable<DoctorExperience>> GetDoctorExperiancesAsync(int doctorId);
    }
}