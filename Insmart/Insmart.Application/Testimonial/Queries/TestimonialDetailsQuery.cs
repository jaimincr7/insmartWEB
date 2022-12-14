using MediatR;

namespace Insmart.Application.Testimonials.Queries
{
    public class TestimonialDetailsQuery: IRequest<TestimonialDetailsQueryResult>
    {
        public int Id { get; set; }
    }
}
