using Insmart.Core;
using MediatR;

namespace Insmart.Application.Blogs.Queries
{
    public class BlogListQuery : PaginationFilter, IRequest<BlogListQueryResult>
    {
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public BlogListQuery() { }

        public BlogListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }

    }
}
