using Insmart.Core.DTOs;
using Insmart.Application.Blogs.Queries;
using Insmart.Application.Blogs;

namespace Insmart.Application.Interfaces
{
    public interface IBlogRepository : IBaseRepository<Blog>
    {
        Task<BlogListQueryResult> GetAllBlogsAsync(BlogListQuery request);

        Task<BlogDetailsQueryResult> GetBlogDetailsAsync(int blogId);
    }
}