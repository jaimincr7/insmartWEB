using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("blog_categories")]
    public class BlogCategory : BaseEntity
    {
        [Key]
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
