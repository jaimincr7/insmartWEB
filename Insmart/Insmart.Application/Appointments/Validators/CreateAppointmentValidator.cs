using FluentValidation;
using Insmart.Application.Appointments.Commands;

namespace Insmart.Application.Appointments.Validators
{
    public class CreateAppointmentCommandValidator : AbstractValidator<CreateAppointmentCommand>
    {
        public CreateAppointmentCommandValidator()
        {
            RuleFor(t => t.AppointmentNumber).NotNull().NotEmpty();
            RuleFor(t => t.DoctorId).NotNull().NotEqual(0);
            RuleFor(t => t.PatientId).NotNull().NotEqual(0);
            RuleFor(t => t.ServiceTypeId).NotNull().NotEqual(0);
            RuleFor(t => t.UserId).NotNull().NotEqual(0);
            RuleFor(t => t.AppointmentStatus).NotNull();
            RuleFor(t => t.Charge).NotNull();
            RuleFor(t => t.IsWalletUsed).NotNull();
            RuleFor(t => t.IsFollowup).NotNull();
        }
    }
}
