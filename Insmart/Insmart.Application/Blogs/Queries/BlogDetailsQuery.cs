using Insmart.Application.Models;
using MediatR;

namespace Insmart.Application.Blogs.Queries
{
    public class BlogDetailsQuery : GetQuery, IRequest<BlogDetailsQueryResult>
    {
    }
}
