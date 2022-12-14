using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Languages.Queries;

namespace Insmart.Application.Languages.Handlers
{
    public class LanguageDetailsQueryHandler : IRequestHandler<GetLanguageDetailsQuery, LanguageDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LanguageDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LanguageDetailsQueryResult> Handle(GetLanguageDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
