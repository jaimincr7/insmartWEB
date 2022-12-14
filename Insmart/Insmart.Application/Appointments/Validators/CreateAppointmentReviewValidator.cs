using FluentValidation;
using Insmart.Application.Appointments.Commands;

namespace Insmart.Application.Appointments.Validators
{
    public class CreateAppointmentReviewCommandValidator : AbstractValidator<CreateAppointmentReviewCommand>
    {
        public CreateAppointmentReviewCommandValidator()
        {
            RuleFor(t => t.AppointmentId).NotNull().NotEqual(0);
            RuleFor(t => t.DoctorId).NotNull().NotEqual(0);
            RuleFor(t => t.UserId).NotNull().NotEqual(0);
            RuleFor(t => t.Ratings).NotNull();
        }
    }
}
