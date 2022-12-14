using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("doctor_awards")]
    public class DoctorAward : BaseEntity
    {
        public int DoctorAwardId { get; set; }
        public int DoctorId { get; set; }
        public string Award { get; set; } = null!;
        public string Year { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedBy { get; set; }
    }
}
