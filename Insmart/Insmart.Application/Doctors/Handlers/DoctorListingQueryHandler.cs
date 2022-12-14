using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Doctors.Queries;

namespace Insmart.Application.Doctors.Handlers
{
    public class DoctorListingQueryHandler : IRequestHandler<DoctorListQuery, DoctorListingQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DoctorListingQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<DoctorListingQueryResult> Handle(DoctorListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Doctors.GetDoctorListAsync(request);
        }
    }
}
