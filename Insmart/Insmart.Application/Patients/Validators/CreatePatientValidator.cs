using FluentValidation;
using Insmart.Application.Patients.Commands;

namespace Insmart.Application.Patients.Validators
{
    public class CreatePatientCommandValidator : AbstractValidator<CreatePatientCommand>
    {
        public CreatePatientCommandValidator()
        {
            RuleFor(t => t.PatientId).NotNull().NotEqual(0);
            RuleFor(t => t.FullName).NotNull().NotEmpty();
            RuleFor(t => t.Email).NotNull().NotEmpty();
            RuleFor(t => t.CountryId).NotNull().NotEqual(0);
            RuleFor(t => t.PhoneCode).NotNull().NotEqual(0);
            RuleFor(t => t.MobileNumber).NotNull().NotEmpty();
            RuleFor(t => t.RelationId).NotNull().NotEqual(0);
            RuleFor(t => t.UserId).NotNull().NotEqual(0);
        }
    }
}
