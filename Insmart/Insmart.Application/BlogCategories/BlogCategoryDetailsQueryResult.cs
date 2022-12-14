namespace Insmart.Application.BlogCategories
{
    public class BlogCategoryDetailsQueryResult
    {
        public int BlogCategoryId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
