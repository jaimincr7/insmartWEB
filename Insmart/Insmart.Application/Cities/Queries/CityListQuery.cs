using Insmart.Core;
using MediatR;

namespace Insmart.Application.Cities.Queries
{
    public class CityListQuery : PaginationFilter, IRequest<CityListQueryResult>
    {
        public int StateId { get; set; }
        public string? Name { get; set; }
        public CityListQuery() { }

        public CityListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
