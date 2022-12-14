using MediatR;

namespace Insmart.Application.Appointments.Commands
{
    public class CreateAppointmentReviewCommand : IRequest<int>
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
    }
}
