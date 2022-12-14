using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("relations")]
    public class Relation : BaseEntity
    {
        [Key]
        public int RelationId { get; set; }
        public string Name { get; set; } = null!;
    }
}
