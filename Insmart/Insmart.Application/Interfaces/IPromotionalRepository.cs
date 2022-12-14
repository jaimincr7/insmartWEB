using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface IPromotionalRepository : IBaseRepository<Promotional>
    {
        Task<IEnumerable<Promotional>> GetAllPromotionsAsync();
    }
}