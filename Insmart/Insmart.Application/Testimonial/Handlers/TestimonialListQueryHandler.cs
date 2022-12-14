using AutoMapper;
using MediatR;
using Insmart.Application.Interfaces;
using Insmart.Application.Testimonials.Queries;
using Insmart.Core.DTOs;
using Insmart.Core;

namespace Insmart.Application.Testimonials.Handlers
{
    public class TestimonialListQueryHandler : IRequestHandler<TestimonialListQuery, TestimonialListQueryResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TestimonialListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<TestimonialListQueryResult> Handle(TestimonialListQuery request, CancellationToken cancellationToken)
        {
            var result = new TestimonialListQueryResult();
            var dataQuery = new DapperQueryAndParams<Testimonial>()
            {
                RawSql = Constants.IsActiveIsDeletedWhere,
                Parameters = new Testimonial { IsActive = true, IsDeleted = false }
            };

            IEnumerable<Testimonial> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.Testimonials.GetAllAsync(dataQuery, "TestimonialId desc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.Testimonials.GetAllAsync(dataQuery, "TestimonialId desc");
            }

            result.Testimonials = _mapper.Map<IEnumerable<TestimonialDetailsQueryResult>>(items);

            return result;
        }
    }
}
