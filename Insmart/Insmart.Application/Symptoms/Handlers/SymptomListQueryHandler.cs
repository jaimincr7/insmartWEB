using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Symptoms.Queries;

namespace Insmart.Application.Symptoms.Handlers
{
    public class SymptomListQueryHandler : IRequestHandler<SymptomListQuery, SymptomListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SymptomListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<SymptomListQueryResult> Handle(SymptomListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Symptoms.GetAllSymptomsAsync(request);
        }
    }
}
