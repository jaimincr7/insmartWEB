using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Promotionals;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class PromotionalMappingProfile: Profile
    {
        public PromotionalMappingProfile()
        {
            CreateMap<Promotional, PromotionalDetailsQueryResult>();
        }
    }
}
