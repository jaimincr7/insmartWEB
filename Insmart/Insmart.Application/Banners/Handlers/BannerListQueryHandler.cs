using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Banners.Queries;

namespace Insmart.Application.Banners.Handlers
{
    public class BannerListQueryHandler : IRequestHandler<BannerListQuery, BannerListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BannerListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BannerListQueryResult> Handle(BannerListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Banners.GetAllBannersAsync(request);
        }
    }
}
