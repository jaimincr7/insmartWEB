using AutoMapper;
using Insmart.Application.Features.Auth.Results;
using Insmart.Core.DTOs;

namespace Insmart.Application.Features.Auth.MappingProfiles
{
    public class AuthMappingProfile : Profile
    {
        public AuthMappingProfile()
        {
            CreateMap<User, LoginQueryResult>().ForMember(dest => dest.UserId, input => input.MapFrom(i => i.UserId));

            CreateMap<User, LoginWithOTPQueryResult>().ForMember(dest => dest.UserId, input => input.MapFrom(i => i.UserId));
        }
    }
}
