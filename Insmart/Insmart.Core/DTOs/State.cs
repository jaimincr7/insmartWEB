using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("states")]
    public class State : BaseEntity
    {
        [Key]
        public int StateId { get; set; }
        public string Name { get; set; } = null!;
        public int CountryId { get; set; }
    }
}
