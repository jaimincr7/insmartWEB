namespace Insmart.Application.Blogs
{
    public class BlogListQueryResult : ListQueryResult
    {
        public IEnumerable<BlogDetailsQueryResult> Blogs { get; set; }
    }
}
