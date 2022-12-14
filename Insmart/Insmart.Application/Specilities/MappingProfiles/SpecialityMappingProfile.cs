using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Specialities;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class SpecialityMappingProfile: Profile
    {
        public SpecialityMappingProfile()
        {
            CreateMap<Speciality, SpecialityDetailsQueryResult>();
        }
    }
}
