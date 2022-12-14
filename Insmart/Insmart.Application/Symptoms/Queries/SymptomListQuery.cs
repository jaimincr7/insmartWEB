using Insmart.Core;
using MediatR;

namespace Insmart.Application.Symptoms.Queries
{
    public class SymptomListQuery : PaginationFilter, IRequest<SymptomListQueryResult>
    {
        public int LanguageId { get; set; }
        public SymptomListQuery() { }

        public SymptomListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
