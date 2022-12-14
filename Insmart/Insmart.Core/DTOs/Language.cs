using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("languages")]
    public class Language : BaseEntity
    {
        [Key]
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
