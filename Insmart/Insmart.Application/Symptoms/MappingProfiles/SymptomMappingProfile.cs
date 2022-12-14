using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Symptoms;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class SymptomMappingProfile: Profile
    {
        public SymptomMappingProfile()
        {
            CreateMap<Symptom, SymptomDetailsQueryResult>();
        }
    }
}
