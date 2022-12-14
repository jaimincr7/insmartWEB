using MediatR;

namespace Insmart.Application.Hospitals.Queries
{
    public class HospitalDetailsQuery: IRequest<HospitalDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
