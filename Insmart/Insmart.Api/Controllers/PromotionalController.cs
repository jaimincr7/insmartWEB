
using Insmart.Application.Promotionals.Queries;
using Insmart.Application.Promotionals;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class PromotionalsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<PromotionalsController> _logger;

        public PromotionalsController(IMediator mediator, ILogger<PromotionalsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPromotionals()
        {
            try
            {
                var query = new PromotionalListQuery();
                var promotionals = await _mediator.Send(query);

                var response = new ApiResponse<PromotionalListQueryResult>()
                {
                    IsSuccess=true,
                    Data = promotionals
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllPromotionals");
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
