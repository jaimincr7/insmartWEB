using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.BlogCategories.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.BlogCategories.Handlers
{
    public class BlogCategoryListQueryHandler : IRequestHandler<BlogCategoryListQuery, BlogCategoryListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogCategoryListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BlogCategoryListQueryResult> Handle(BlogCategoryListQuery request, CancellationToken cancellationToken)
        {
            var result = new BlogCategoryListQueryResult();
            var dataQuery = new DapperQueryAndParams<BlogCategory>()
            {
                RawSql = Constants.IsActiveIsDeletedWhere,
                Parameters = new BlogCategory { IsActive = true, IsDeleted = false }
            };

            IEnumerable<BlogCategory> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.BlogCategories.GetAllAsync(dataQuery, "Name asc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.BlogCategories.GetAllAsync(dataQuery, "Name asc");
            }

            result.BlogCategories = _mapper.Map<IEnumerable<BlogCategoryDetailsQueryResult>>(items);

            return result;
        }
    }
}
