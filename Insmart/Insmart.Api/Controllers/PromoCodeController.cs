
using Insmart.Application.PromoCodes.Queries;
using Insmart.Application.PromoCodes;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class PromoCodesController : BaseApiController
    {
        IMediator _mediator;
        ILogger<PromoCodesController> _logger;

        public PromoCodesController(IMediator mediator, ILogger<PromoCodesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPromoCodes([FromQuery] PromoCodeListQuery query)
        {
            try
            {
                if (query == null) query = new PromoCodeListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<PromoCodeListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllPromoCodes");
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
