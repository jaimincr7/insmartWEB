using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Promotionals.Queries;

namespace Insmart.Application.Promotionals.Handlers
{
    public class PromotionalDetailsQueryHandler : IRequestHandler<PromotionalDetailsQuery, PromotionalDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PromotionalDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<PromotionalDetailsQueryResult> Handle(PromotionalDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
