using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Blogs.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Blogs.Handlers
{
    public class GetBlogListQueryHandler : IRequestHandler<BlogListQuery, BlogListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetBlogListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BlogListQueryResult> Handle(BlogListQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Blogs.GetAllBlogsAsync(request);
        }
    }
}
