using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Banners;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class BannerMappingProfile: Profile
    {
        public BannerMappingProfile()
        {
            CreateMap<Banner, BannerDetailsQueryResult>();
        }
    }
}
