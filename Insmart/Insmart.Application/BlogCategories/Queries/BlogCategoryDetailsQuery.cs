using MediatR;

namespace Insmart.Application.BlogCategories.Queries
{
    public class BlogCategoryDetailsQuery: IRequest<BlogCategoryDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
