using Insmart.Application.Cities;
using Insmart.Application.Cities.Queries;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface ICityRepository : IBaseRepository<City>
    {
        Task<CityListQueryResult> GetAllCitiesAsync(CityListQuery request);
    }
}