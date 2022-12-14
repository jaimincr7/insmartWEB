using Insmart.Application.Hospitals.Queries;
using Insmart.Application.Hospitals;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface IHospitalRepository : IBaseRepository<Hospital>
    {
        Task<HospitalListQueryResult> GetAllPromotionalAsync(int promotionalId);

        Task<HospitalListQueryResult> GetAllHospitalsAsync(HospitalListQuery request);
    }
}