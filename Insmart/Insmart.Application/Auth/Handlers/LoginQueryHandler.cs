using AutoMapper;
using FluentValidation;
using Insmart.Application.Features.Auth.Queries;
using Insmart.Application.Features.Auth.Results;
using Insmart.Application.Interfaces;
using Insmart.Application.Interfaces.Services;
using Insmart.Application.Models;
using Insmart.Core;
using Insmart.Core.DTOs;
using MediatR;

namespace Insmart.Application.Features.Auth.Handlers
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery, LoginQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHashService _passwordHashService;

        public LoginQueryHandler(IUnitOfWork unitOfWork, IMapper mapper,
            ITokenService tokenService, IPasswordHashService passwordHashService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
            _passwordHashService = passwordHashService;
        }
        public async Task<LoginQueryResult> Handle(LoginQuery query, CancellationToken cancellationToken)
        {
            LoginQueryResult result = null;
            var dataQuery = new DapperQueryAndParams<User>()
            {
                RawSql = $"(MobileNumber=@UserName or Email=@UserName) and IsDeleted=@IsDeleted and IsActive=@IsActive",
                Parameters = new User() { UserName = query.UserName, IsActive = true, IsDeleted = false }
            };
            var user = await _unitOfWork.Users.GetAsync(dataQuery);

            if (user != null && _passwordHashService.ValidatePassword(query.Password, user.PasswordHash))  //TODOD - Validate InActive=false and Password Hash instead of PlainText
            {
                result = _mapper.Map<LoginQueryResult>(user);
                result.Token = _tokenService.CreateToken(new TokenRequest()
                {
                    UserId = result.UserId,
                    Email = result.Email
                });
            }

            return result;
        }
    }
}
