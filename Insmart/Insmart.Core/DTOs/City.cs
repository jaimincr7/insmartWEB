using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("cities")]
    public class City : BaseEntity
    {
        [Key]
        public int CityId { get; set; }
        public string Name { get; set; } = null!;
        public int StateId { get; set; }
    }
}
