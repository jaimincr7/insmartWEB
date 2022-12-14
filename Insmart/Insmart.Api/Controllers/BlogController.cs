
using Insmart.Application.Blogs.Queries;
using Insmart.Application.Blogs;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class BlogsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<BlogsController> _logger;

        public BlogsController(IMediator mediator, ILogger<BlogsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogs([FromQuery] BlogListQuery query)
        {
            try
            {
                if (query == null) query = new BlogListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<BlogListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllBlogs");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            try
            {
                var data = await _mediator.Send(new BlogDetailsQuery { Id = id });
                var response = new ApiResponse<BlogDetailsQueryResult>(data);
                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetBlog");
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
