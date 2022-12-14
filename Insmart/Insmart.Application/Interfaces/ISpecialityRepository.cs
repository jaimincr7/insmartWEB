using Insmart.Application.Specialities.Queries;
using Insmart.Application.Specialities;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface ISpecialityRepository : IBaseRepository<Speciality>
    {
        Task<IEnumerable<Speciality>> GetAllPromotionalAsync(int promotionalId);

        Task<SpecialityListQueryResult> GetAllSpecialitiesAsync(SpecialityListQuery request);
    }
}