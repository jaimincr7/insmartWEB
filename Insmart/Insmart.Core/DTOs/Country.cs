using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("countries")]
    public class Country : BaseEntity
    {
        [Key]
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Code3 { get; set; }
        public int PhoneCode { get; set; }
    }
}
