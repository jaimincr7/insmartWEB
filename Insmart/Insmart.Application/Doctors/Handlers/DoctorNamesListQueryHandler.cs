using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Doctors.Queries;

namespace Insmart.Application.Doctors.Handlers
{
    public class DoctorNamesListQueryHandler : IRequestHandler<DoctorNamesListQuery, DoctorNamesListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoctorNamesListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DoctorNamesListQueryResult> Handle(DoctorNamesListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Doctors.GetHomePageDoctorsAsync(request);
        }
    }
}
