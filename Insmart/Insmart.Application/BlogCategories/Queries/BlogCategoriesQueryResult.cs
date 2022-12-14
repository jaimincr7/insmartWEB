using MediatR;

namespace Insmart.Application.BlogCategories.Queries
{
    public class GetBlogCategoriesQuery : IRequest<IList<BlogCategoryDetailsQueryResult>>
    {
    }
}
