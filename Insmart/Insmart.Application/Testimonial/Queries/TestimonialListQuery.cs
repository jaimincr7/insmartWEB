using Insmart.Core;
using MediatR;

namespace Insmart.Application.Testimonials.Queries
{
    public class TestimonialListQuery : PaginationFilter, IRequest<TestimonialListQueryResult>
    {
        public TestimonialListQuery() { }

        public TestimonialListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }
    }
}
