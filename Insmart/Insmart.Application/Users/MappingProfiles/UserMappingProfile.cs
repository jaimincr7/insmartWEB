using AutoMapper;
using Insmart.Application.Features.Auth.Queries;
using Insmart.Application.Users.Commands;
using Insmart.Core.DTOs;

namespace Insmart.Application.Users.MappingProfiles
{
    public class UserMappingProfile : Profile
    {
        public UserMappingProfile()
        {
            CreateMap<CreateUserCommand, User>();
            CreateMap<UpdateUserCommand, User>();
            CreateMap<ChangePasswordQuery, User>();
            CreateMap<CreateUserAddressCommand, UserAddress>();
        }
    }
}
