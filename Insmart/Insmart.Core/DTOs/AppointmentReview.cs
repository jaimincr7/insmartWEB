using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("appointment_reviews")]
    public partial class AppointmentReview : BaseEntity
    {
        public int AppointmentReviewId { get; set; }
        public long AppointmentId { get; set; }
        public int UserId { get; set; }
        public int DoctorId { get; set; }
        public int Ratings { get; set; }
        public string? Comment { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
