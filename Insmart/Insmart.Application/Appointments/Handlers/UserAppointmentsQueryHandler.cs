﻿using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Appointments.Queries;

namespace Insmart.Application.Appointments.Handlers
{
    public class UserAppointmentsQueryHandler : IRequestHandler<UserAppointmentsQuery, IList<AppointmentDetailsQueryResult>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserAppointmentsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<IList<AppointmentDetailsQueryResult>> Handle(UserAppointmentsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
