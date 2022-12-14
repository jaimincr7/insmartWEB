
using Insmart.Application.Testimonials.Queries;
using Insmart.Application.Testimonials;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class TestimonialsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<TestimonialsController> _logger;

        public TestimonialsController(IMediator mediator, ILogger<TestimonialsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllTestimonials([FromQuery] TestimonialListQuery query)
        {
            try
            {
                if (query == null) query = new TestimonialListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<TestimonialListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllTestimonials");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }
    }
}
