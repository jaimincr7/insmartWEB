using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Appointments.Commands;
using Insmart.Application.Appointments;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class AppointmentMappingProfile: Profile
    {
        public AppointmentMappingProfile()
        {
            CreateMap<CreateAppointmentCommand, Appointment>();
            CreateMap<Appointment, AppointmentDetailsQueryResult>();
            CreateMap<CreateAppointmentReviewCommand, AppointmentReview>();
        }
    }
}
