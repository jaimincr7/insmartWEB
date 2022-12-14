using Insmart.Core;
using MediatR;

namespace Insmart.Application.PromoCodes.Queries
{
    public class PromoCodeListQuery : PaginationFilter, IRequest<PromoCodeListQueryResult>
    {
        public PromoCodeListQuery() { }

        public PromoCodeListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
