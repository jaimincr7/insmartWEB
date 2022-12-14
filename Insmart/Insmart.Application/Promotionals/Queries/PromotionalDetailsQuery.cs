using MediatR;

namespace Insmart.Application.Promotionals.Queries
{
    public class PromotionalDetailsQuery: IRequest<PromotionalDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
