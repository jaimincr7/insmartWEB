using AutoMapper;
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
    public class LoginWithOTPQueryHandler : IRequestHandler<LoginWithOTPQuery, LoginWithOTPQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHashService _passwordHashService;
        public LoginWithOTPQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ITokenService tokenService, IPasswordHashService passwordHashService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
            _passwordHashService = passwordHashService;
        }
        public async Task<LoginWithOTPQueryResult> Handle(LoginWithOTPQuery query, CancellationToken cancellationToken)
        {
            LoginWithOTPQueryResult? result = new LoginWithOTPQueryResult();
            var dataQuery = new DapperQueryAndParams<User>()
            {
                RawSql = $"MobileNumber=@MobileNumber and IsDeleted=@IsDeleted and IsActive=@IsActive",
                Parameters = new User() { MobileNumber = query.MobileNumber, IsActive = true, IsDeleted = false }
            };
            var user = await _unitOfWork.Users.GetAsync(dataQuery);
            if (user == null || user.UserId == 0)
            {
                return result;
            }

            var otpQuery = new DapperQueryAndParams<UserOTP>()
            {
                RawSql = $"UserId=@UserId",
                Parameters = new UserOTP() { UserId = user.UserId }
            };
            var userOTP = await _unitOfWork.UserOTPs.GetAsync(otpQuery);
            if (userOTP.OTP == query.OTP)  
            {
                result = _mapper.Map<LoginWithOTPQueryResult>(user);
                result.Token = _tokenService.CreateToken(new TokenRequest()
                {
                    UserId = result.UserId,
                    Email = result.Email
                });
                UserOTP otpObj = new UserOTP()
                {
                    UserOTPId = userOTP.UserOTPId,
                };
                _unitOfWork.UserOTPs.DeleteAsync(otpObj);
            }
            else
            {
                result = null;
            }
            return result;
        }
    }
}
