using MediatR;

namespace Insmart.Application.PromoCodes.Queries
{
    public class PromoCodeDetailsQuery: IRequest<PromoCodeDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
