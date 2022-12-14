using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Symptoms.Queries;

namespace Insmart.Application.Symptoms.Handlers
{
    public class SymptomDetailsQueryHandler : IRequestHandler<SymptomDetailsQuery, SymptomDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SymptomDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SymptomDetailsQueryResult> Handle(SymptomDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
