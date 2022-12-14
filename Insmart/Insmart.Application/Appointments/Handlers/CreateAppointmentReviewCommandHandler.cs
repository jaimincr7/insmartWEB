using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Appointments.Commands;
using Insmart.Application.Interfaces.Services;
using Insmart.Core.DTOs;

namespace Insmart.Application.Appointments.Handlers
{
    public class CreateAppointmentReviewCommandHandler : IRequestHandler<CreateAppointmentReviewCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateAppointmentReviewCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreateAppointmentReviewCommand command, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.AppointmentReviews.AddAsync(_mapper.Map<AppointmentReview>(command));
            return Convert.ToInt32(result);
        }
    }
}
