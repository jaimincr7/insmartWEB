using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Patients.Commands;
using Insmart.Application.Interfaces.Services;
using Insmart.Core.DTOs;

namespace Insmart.Application.Patients.Handlers
{
    public class CreatePatientCommandHandler : IRequestHandler<CreatePatientCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreatePatientCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePatientCommand command, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Patients.AddAsync(_mapper.Map<Patient>(command));
            return Convert.ToInt32(result);
        }
    }
}
