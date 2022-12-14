using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Banners.Queries;

namespace Insmart.Application.Banners.Handlers
{
    public class BannerDetailsQueryHandler : IRequestHandler<BannerDetailsQuery, BannerDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BannerDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BannerDetailsQueryResult> Handle(BannerDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
