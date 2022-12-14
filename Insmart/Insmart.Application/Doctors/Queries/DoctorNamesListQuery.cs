using Insmart.Core;
using MediatR;

namespace Insmart.Application.Doctors.Queries
{
    public class DoctorNamesListQuery : PaginationFilter, IRequest<DoctorNamesListQueryResult>
    {
        public string? Name { get; set; }

        public DoctorNamesListQuery() { }

        public DoctorNamesListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }
    }
}
