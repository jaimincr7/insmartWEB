using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Appointments.Commands;
using Insmart.Application.Interfaces.Services;
using Insmart.Core.DTOs;

namespace Insmart.Application.Appointments.Handlers
{
    public class CreateAppointmentCommandHandler : IRequestHandler<CreateAppointmentCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateAppointmentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateAppointmentCommand command, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Appointments.AddAsync(_mapper.Map<Appointment>(command));
            return Convert.ToInt32(result);
        }
    }
}
