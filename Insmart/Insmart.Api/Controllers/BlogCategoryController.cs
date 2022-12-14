
using Insmart.Application.BlogCategories.Queries;
using Insmart.Application.BlogCategories;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class BlogCategoriesController : BaseApiController
    {
        IMediator _mediator;
        ILogger<BlogCategoriesController> _logger;

        public BlogCategoriesController(IMediator mediator, ILogger<BlogCategoriesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBlogCategories([FromQuery] BlogCategoryListQuery query)
        {
            try
            {
                if (query == null) query = new BlogCategoryListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<BlogCategoryListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllBlogCategories");
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
