using Insmart.Core;
using MediatR;

namespace Insmart.Application.BlogCategories.Queries
{
    public class BlogCategoryListQuery : PaginationFilter, IRequest<BlogCategoryListQueryResult>
    {
        public BlogCategoryListQuery() { }

        public BlogCategoryListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
