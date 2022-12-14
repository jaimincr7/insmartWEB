using MediatR;

namespace Insmart.Application.Appointments.Queries
{
    public class UserAppointmentsQuery: IRequest<IList<AppointmentDetailsQueryResult>>
    {
    }
}
