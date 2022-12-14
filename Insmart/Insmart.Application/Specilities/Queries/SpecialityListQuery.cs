using Insmart.Core;
using MediatR;

namespace Insmart.Application.Specialities.Queries
{
    public class SpecialityListQuery : PaginationFilter, IRequest<SpecialityListQueryResult>
    {
        public string? Name { get; set; }
        public int LanguageId { get; set; }

        public SpecialityListQuery() { }

        public SpecialityListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }
    }
}
