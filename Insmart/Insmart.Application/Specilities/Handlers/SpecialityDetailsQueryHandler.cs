using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Specialities.Queries;

namespace Insmart.Application.Specialities.Handlers
{
    public class SpecialityDetailsQueryHandler : IRequestHandler<SpecialityDetailsQuery, SpecialityDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SpecialityDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SpecialityDetailsQueryResult> Handle(SpecialityDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
