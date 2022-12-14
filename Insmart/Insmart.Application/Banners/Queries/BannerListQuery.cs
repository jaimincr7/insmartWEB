using Insmart.Core;
using MediatR;

namespace Insmart.Application.Banners.Queries
{
    public class BannerListQuery : PaginationFilter, IRequest<BannerListQueryResult>
    {
        public int LanguageId { get; set; }
        public int BannerType { get; set; }
        public BannerListQuery() { }

        public BannerListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
