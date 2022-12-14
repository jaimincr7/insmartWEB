using AutoMapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Users.Commands;
using Insmart.Core.DTOs;
using MediatR;

namespace Insmart.Application.UserAddresss.Handlers
{
    public class CreateUserAddressCommandHandler : IRequestHandler<CreateUserAddressCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public CreateUserAddressCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateUserAddressCommand command, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.UserAddresses.AddAsync(_mapper.Map<UserAddress>(command));
            
            return Convert.ToInt32(result);
        }
    }
}
