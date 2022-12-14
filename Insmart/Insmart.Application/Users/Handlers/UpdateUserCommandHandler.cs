using AutoMapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Users.Commands;
using MediatR;

namespace Insmart.Application.Users.Handlers
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UpdateUserCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<bool> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
        {
            var existingItem = await _unitOfWork.Users.GetAsync(command.Id);
            if (existingItem != null)
            {
                _mapper.Map(command, existingItem);
                var result = await _unitOfWork.Users.UpdateAsync(existingItem);
                return result;
            }
            return false;
        }
    }
}
