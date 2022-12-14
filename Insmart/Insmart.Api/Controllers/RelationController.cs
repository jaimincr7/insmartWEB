
using Insmart.Apis;
using Insmart.Application.Relations;
using Insmart.Application.Relations.Queries;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class RelationsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<RelationsController> _logger;

        public RelationsController(IMediator mediator, ILogger<RelationsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRelations()
        {
            try
            {
                var query = new RelationListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<RelationListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllRelations");
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
