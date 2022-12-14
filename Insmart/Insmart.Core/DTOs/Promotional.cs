using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("promotionals")]
    public class Promotional : BaseEntity
    {
        [Key]
        public int PromotionalId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PromotionalType { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
