using AutoMapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Interfaces.Services;
using Insmart.Application.Users.Commands;
using Insmart.Core.DTOs;
using MediatR;

namespace Insmart.Application.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IPasswordHashService _passwordHashService;
        public CreateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IPasswordHashService passwordHashService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _passwordHashService = passwordHashService;
        }
        public async Task<int> Handle(CreateUserCommand command, CancellationToken cancellationToken)
        {
            command.PasswordHash= _passwordHashService.CreateHash(command.PasswordHash);
            var result = await _unitOfWork.Users.AddAsync(_mapper.Map<User>(command));
            
            return Convert.ToInt32(result);
        }
    }
}
