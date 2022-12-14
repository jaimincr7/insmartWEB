using AutoMapper;
using Insmart.Core.DTOs;
using Insmart.Application.Testimonials;

namespace Insmart.Application.Tasks.MappingProfiles
{
    public class TestimonialMappingProfile: Profile
    {
        public TestimonialMappingProfile()
        {
            CreateMap<Testimonial, TestimonialDetailsQueryResult>();
        }
    }
}
