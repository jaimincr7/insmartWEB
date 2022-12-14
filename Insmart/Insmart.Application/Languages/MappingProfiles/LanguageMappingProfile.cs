using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Languages;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class LanguageMappingProfile: Profile
    {
        public LanguageMappingProfile()
        {
            CreateMap<Language, LanguageDetailsQueryResult>();
        }
    }
}
