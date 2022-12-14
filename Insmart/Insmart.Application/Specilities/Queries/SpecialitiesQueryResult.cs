using MediatR;

namespace Insmart.Application.Specialities.Queries
{
    public class GetSpecialitiesQuery : IRequest<IList<SpecialityDetailsQueryResult>>
    {
    }
}
