
using Insmart.Application.Symptoms.Queries;
using Insmart.Application.Symptoms;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class SymptomsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<SymptomsController> _logger;

        public SymptomsController(IMediator mediator, ILogger<SymptomsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSymptoms([FromQuery] SymptomListQuery query)
        {
            try
            {
                if (query == null) query = new SymptomListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<SymptomListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllSymptoms");
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
