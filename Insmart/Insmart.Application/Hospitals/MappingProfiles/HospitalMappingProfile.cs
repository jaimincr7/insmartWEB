using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Hospitals;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class HospitalMappingProfile: Profile
    {
        public HospitalMappingProfile()
        {
            CreateMap<Hospital, HospitalDetailsQueryResult>();
        }
    }
}
