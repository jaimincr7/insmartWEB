using Insmart.Core;
using MediatR;

namespace Insmart.Application.Hospitals.Queries
{
    public class HospitalListQuery : PaginationFilter, IRequest<HospitalListQueryResult>
    {
        public string? Name { get; set; }
        public int? CityId { get; set; }

        public HospitalListQuery() { }

        public HospitalListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }
    }
}
