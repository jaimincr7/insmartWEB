using Dapper.Contrib.Extensions;

namespace Insmart.Application.Blogs
{
    public class BlogDetailsQueryResult 
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BlogCategoryId { get; set; }
        public int PrevBlogId { get; set; }
        public int NextBlogId { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
