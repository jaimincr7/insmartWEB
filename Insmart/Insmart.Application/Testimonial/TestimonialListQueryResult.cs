namespace Insmart.Application.Testimonials
{
    public class TestimonialListQueryResult : ListQueryResult
    {
        public IEnumerable<TestimonialDetailsQueryResult> Testimonials { get; set; }
    }
}
