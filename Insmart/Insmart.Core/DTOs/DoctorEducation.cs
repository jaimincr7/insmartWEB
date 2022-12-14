using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("doctor_educations")]
    public partial class DoctorEducation : BaseEntity
    {
        public int DoctorEducationId { get; set; }
        public int DoctorId { get; set; }
        public string Degree { get; set; } = null!;
        public string College { get; set; } = null!;
        public DateTime CompletionYear { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
