using Insmart.Core;
using MediatR;

namespace Insmart.Application.Appointments.Queries
{
    public class AppointmentListQuery : PaginationFilter, IRequest<AppointmentListQueryResult>
    {
        public AppointmentListQuery() { }

        public AppointmentListQuery(int userId, int pageIndex, int pageSize)
        {
            UserId = userId;            
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

        public int UserId { get; set; }
    }
}
