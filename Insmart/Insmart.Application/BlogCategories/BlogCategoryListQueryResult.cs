namespace Insmart.Application.BlogCategories
{
    public class BlogCategoryListQueryResult : ListQueryResult
    {
        public IEnumerable<BlogCategoryDetailsQueryResult> BlogCategories { get; set; }
    }
}
