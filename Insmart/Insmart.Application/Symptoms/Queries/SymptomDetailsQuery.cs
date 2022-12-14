using MediatR;

namespace Insmart.Application.Symptoms.Queries
{
    public class SymptomDetailsQuery: IRequest<SymptomDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
