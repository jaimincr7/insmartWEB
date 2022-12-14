
using Insmart.Application.Specialities.Queries;
using Insmart.Application.Specialities;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class SpecialitiesController : BaseApiController
    {
        IMediator _mediator;
        ILogger<SpecialitiesController> _logger;

        public SpecialitiesController(IMediator mediator, ILogger<SpecialitiesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllSpecialities([FromQuery] SpecialityListQuery query)
        {
            try
            {
                if (query == null) query = new SpecialityListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<SpecialityListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllSpecialities");
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
