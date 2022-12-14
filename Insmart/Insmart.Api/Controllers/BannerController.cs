
using Insmart.Apis;
using Insmart.Application.Banners;
using Insmart.Application.Banners.Queries;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class BannersController : BaseApiController
    {
        IMediator _mediator;
        ILogger<BannersController> _logger;

        public BannersController(IMediator mediator, ILogger<BannersController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBanners([FromQuery] BannerListQuery query)
        {
            try
            {
                if (query == null) query = new BannerListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<BannerListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllBanners");
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
