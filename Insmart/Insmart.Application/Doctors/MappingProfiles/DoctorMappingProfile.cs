using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Doctors;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class DoctorMappingProfile: Profile
    {
        public DoctorMappingProfile()
        {
            CreateMap<Doctor, DoctorDetailsQueryResult>();
            CreateMap<DoctorDetailsQueryResult, DoctorCompleteDetailsQueryResult>();
        }
    }
}
