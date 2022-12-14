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
    public class RequestOTPQueryHandler : IRequestHandler<RequestOTPQuery, RequestOTPQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHashService _passwordHashService;
        public RequestOTPQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, ITokenService tokenService, IPasswordHashService passwordHashService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
            _passwordHashService = passwordHashService;
        }
        public async Task<RequestOTPQueryResult> Handle(RequestOTPQuery query, CancellationToken cancellationToken)
        {
            RequestOTPQueryResult result = new RequestOTPQueryResult();
            var dataQuery = new DapperQueryAndParams<User>()
            {
                RawSql = $"(MobileNumber=@UserName or Email=@UserName) and IsDeleted=0 and IsActive=@IsActive",
                Parameters = new User() { MobileNumber = query.Username, Email = query.Username, IsDeleted = false, IsActive = true }
            };
            var user = await _unitOfWork.Users.GetAsync(dataQuery);

            if (user != null)
            {
                Random generator = new Random();
                result.OTP = generator.Next(0, 1000000).ToString("D6"); //TODO:: Send OTP to mobile number or email

                UserOTP otpObj = new UserOTP()
                {
                    UserId = user.UserId,
                    OTP = result.OTP
                };

                await _unitOfWork.UserOTPs.AddAsync(otpObj);
            }

            return result;
        }
    }
}
