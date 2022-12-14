using Insmart.Core.DTOs;
using Insmart.Application.Symptoms;
using Insmart.Application.Symptoms.Queries;

namespace Insmart.Application.Interfaces
{
    public interface ISymptomRepository : IBaseRepository<Symptom>
    {
        Task<IEnumerable<Symptom>> GetAllPromotionalAsync(int promotionalId);

        Task<SymptomListQueryResult> GetAllSymptomsAsync(SymptomListQuery request);
    }
}