using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.PromoCodes.Queries;

namespace Insmart.Application.PromoCodes.Handlers
{
    public class PromoCodeDetailsQueryHandler : IRequestHandler<PromoCodeDetailsQuery, PromoCodeDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PromoCodeDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<PromoCodeDetailsQueryResult> Handle(PromoCodeDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.PromoCodes.GetAsync(request.Id);
            return _mapper.Map<PromoCodeDetailsQueryResult>(result);
        }
    }
}
