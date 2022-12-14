using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.PromoCodes.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.PromoCodes.Handlers
{
    public class PromoCodeListQueryHandler : IRequestHandler<PromoCodeListQuery, PromoCodeListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PromoCodeListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<PromoCodeListQueryResult> Handle(PromoCodeListQuery request, CancellationToken cancellationToken)
        {
            var result = new PromoCodeListQueryResult();
            var dataQuery = new DapperQueryAndParams<PromoCode>()
            {
                RawSql = Constants.IsActiveIsDeletedWhere,
                Parameters = new PromoCode { IsActive = true, IsDeleted = false }
            };

            IEnumerable<PromoCode> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.PromoCodes.GetAllAsync(dataQuery, "PromoCodeId desc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.PromoCodes.GetAllAsync(dataQuery, "PromoCodeId desc");
            }

            result.PromoCodes = _mapper.Map<IEnumerable<PromoCodeDetailsQueryResult>>(items);

            return result;
        }
    }
}
