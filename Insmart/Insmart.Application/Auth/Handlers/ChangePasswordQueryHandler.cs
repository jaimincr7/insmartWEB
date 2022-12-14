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
    public class ChangePasswordQueryHandler : IRequestHandler<ChangePasswordQuery, ChangePasswordQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly IPasswordHashService _passwordHashService;

        public ChangePasswordQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, 
            ITokenService tokenService, IPasswordHashService passwordHashService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _tokenService = tokenService;
            _passwordHashService = passwordHashService;
        }
        public async Task<ChangePasswordQueryResult> Handle(ChangePasswordQuery query, CancellationToken cancellationToken)
        {
            ChangePasswordQueryResult result = new ChangePasswordQueryResult();
            var dataQuery = new DapperQueryAndParams<User>() { 
                RawSql = $"(MobileNumber=@UserName or Email=@UserName) and IsDeleted=0",
                Parameters = new User() { UserName = query.Username }
            };
            var user = await _unitOfWork.Users.GetAsync(dataQuery);

            if (user != null)  //TODOD - Create Password hash
            {
                _mapper.Map(query, user);
                result.IsSuccess = await _unitOfWork.Users.UpdateAsync(user);
            }

            return result;
        }       
    }
}
