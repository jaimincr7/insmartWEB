using MediatR;

namespace Insmart.Application.Appointments.Queries
{
    public class AppointmentDetailsQuery: IRequest<AppointmentDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
