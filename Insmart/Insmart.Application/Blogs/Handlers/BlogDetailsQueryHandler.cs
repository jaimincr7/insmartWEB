using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Blogs.Queries;

namespace Insmart.Application.Blogs.Handlers
{
    public class BlogDetailsQueryHandler : IRequestHandler<BlogDetailsQuery, BlogDetailsQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BlogDetailsQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BlogDetailsQueryResult> Handle(BlogDetailsQuery request, CancellationToken cancellationToken)
        {
            var result = await _unitOfWork.Blogs.GetBlogDetailsAsync(request.Id);
            return _mapper.Map<BlogDetailsQueryResult>(result);
        }
    }
}
