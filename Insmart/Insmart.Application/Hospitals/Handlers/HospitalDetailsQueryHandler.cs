using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Hospitals.Queries;

namespace Insmart.Application.Hospitals.Handlers
{
    public class HospitalDetailsQueryHandler : IRequestHandler<HospitalDetailsQuery, HospitalDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public HospitalDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<HospitalDetailsQueryResult> Handle(HospitalDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
