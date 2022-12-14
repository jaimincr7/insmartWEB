using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.BlogCategories.Queries;

namespace Insmart.Application.BlogCategories.Handlers
{
    public class BlogCategoryDetailsQueryHandler : IRequestHandler<BlogCategoryDetailsQuery, BlogCategoryDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogCategoryDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BlogCategoryDetailsQueryResult> Handle(BlogCategoryDetailsQuery request, CancellationToken cancellationToken)
        {
            //var result = await _unitOfWork.REPO_CLASS_PROP_NAME.Add(_mapper.Map<Insmart.Core.Entities.Task>(request));
            //return result;
            throw new NotImplementedException();
        }
    }
}
