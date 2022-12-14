using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.BlogCategories;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class BlogCategoryMappingProfile: Profile
    {
        public BlogCategoryMappingProfile()
        {
            CreateMap<BlogCategory, BlogCategoryDetailsQueryResult>();
        }
    }
}
