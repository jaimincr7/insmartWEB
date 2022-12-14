using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Patients.Commands;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class PatientMappingProfile: Profile
    {
        public PatientMappingProfile()
        {
            CreateMap<CreatePatientCommand, Patient>();
        }
    }
}
