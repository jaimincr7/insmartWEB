using MediatR;

namespace Insmart.Application.Specialities.Queries
{
    public class SpecialityDetailsQuery: IRequest<SpecialityDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
