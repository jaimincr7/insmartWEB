using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Appointments.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Appointments.Handlers
{
    public class AppointmentListQueryHandler : IRequestHandler<AppointmentListQuery, AppointmentListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AppointmentListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<AppointmentListQueryResult> Handle(AppointmentListQuery request, CancellationToken cancellationToken)
        {
            var result = new AppointmentListQueryResult();
            var dataQuery = new DapperQueryAndParams<Appointment>()
            {
                RawSql = Constants.IsDeletedWhere,
                Parameters = new Appointment { IsDeleted=false}
            };

            IEnumerable<Appointment> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.Appointments.GetAllAsync(dataQuery, "AppointmentId desc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.Appointments.GetAllAsync(dataQuery, "AppointmentId desc");
            }

            result.Appointments = _mapper.Map<IEnumerable<AppointmentDetailsQueryResult>>(items);

            return result;
        }
    }
}
