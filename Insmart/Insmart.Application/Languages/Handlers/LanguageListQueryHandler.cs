using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Languages.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Languages.Handlers
{
    public class LanguageListQueryHandler : IRequestHandler<LanguageListQuery, LanguageListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LanguageListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<LanguageListQueryResult> Handle(LanguageListQuery request, CancellationToken cancellationToken)
        {
            var result = new LanguageListQueryResult();
            var dataQuery = new DapperQueryAndParams<Language>()
            {
                RawSql = Constants.IsActiveWhere,
                Parameters = new Language { IsActive = true }
            };

            IEnumerable<Language> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.Languages.GetAllAsync(dataQuery, "Name Asc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.Languages.GetAllAsync(dataQuery, "Name Asc");
            }

            result.Languages = _mapper.Map<IEnumerable<LanguageDetailsQueryResult>>(items);

            return result;
        }
    }
}
