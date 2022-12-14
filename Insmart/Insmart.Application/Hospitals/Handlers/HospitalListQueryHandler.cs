using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Hospitals.Queries;

namespace Insmart.Application.Hospitals.Handlers
{
    public class HospitalListQueryHandler : IRequestHandler<HospitalListQuery, HospitalListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HospitalListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<HospitalListQueryResult> Handle(HospitalListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Hospitals.GetAllHospitalsAsync(request);
        }
    }
}
