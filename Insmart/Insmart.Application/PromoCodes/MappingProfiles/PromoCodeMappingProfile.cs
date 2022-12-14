using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.PromoCodes;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class PromoCodeMappingProfile: Profile
    {
        public PromoCodeMappingProfile()
        {
            CreateMap<PromoCode, PromoCodeDetailsQueryResult>();
        }
    }
}
