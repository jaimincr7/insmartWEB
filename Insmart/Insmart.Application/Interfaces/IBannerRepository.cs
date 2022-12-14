using Insmart.Application.Banners.Queries;
using Insmart.Application.Banners;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface IBannerRepository : IBaseRepository<Banner>
    {
        Task<BannerListQueryResult> GetAllBannersAsync(BannerListQuery request);
    }
}