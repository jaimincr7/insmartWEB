using System.Globalization;

namespace Insmart.Application.Appointments
{
    public class AppointmentDetailsQueryResult
    {
        public long AppointmentId { get; set; }
        public string AppointmentNumber { get; set; } = null!;
        public int DoctorId { get; set; }
        public string DoctorNumber { get; set; } = null!;
        public string Specialities { get; set; } = null!;
        public int PatientId { get; set; }
        public int UserId { get; set; }
        public int ServiceTypeId { get; set; }
        public DateTime AppointmentDateTime { get; set; }
        public int AddressId { get; set; }
        public sbyte AppointmentStatus { get; set; }
        public decimal Charge { get; set; }
        public int AppointmentBookedByType { get; set; }
        public string Promocode { get; set; } = null!;
        public decimal PromocodeDiscount { get; set; }
        public decimal PromocodeDiscountAmount { get; set; }
        public string CancelComment { get; set; } = null!;
        public int IsWalletUsed { get; set; }
        public decimal WalletAmount { get; set; }
        public bool IsFollowup { get; set; }
        public int FollowupParentAppointmentId { get; set; }
        public string FollowupRemark { get; set; } = null!;
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
