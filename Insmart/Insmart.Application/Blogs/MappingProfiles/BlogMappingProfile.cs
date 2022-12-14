using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Blogs;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class BlogMappingProfile: Profile
    {
        public BlogMappingProfile()
        {
            CreateMap<Blog, BlogDetailsQueryResult>();
        }
    }
}
