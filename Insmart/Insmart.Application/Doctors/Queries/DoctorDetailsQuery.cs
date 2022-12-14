using MediatR;

namespace Insmart.Application.Doctors.Queries
{
    public class DoctorDetailsQuery: IRequest<DoctorCompleteDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
