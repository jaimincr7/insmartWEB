using Insmart.Core;
using Insmart.Core.DTOs;

namespace Insmart.Application.Interfaces
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<long> AddAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(T entity);
        Task<T> GetAsync(long entityID);
        Task<T> GetAsync(DapperQueryAndParams<T> where);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where);
        Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where, string orderBy);
        Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where, string orderBy, Pagination pagination);
        Task<int> Count();
        Task<int> Count(DapperQueryAndParams<T> where);

    }
}
