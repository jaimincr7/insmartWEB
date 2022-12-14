
using Insmart.Apis;
using Insmart.Application.Cities;
using Insmart.Application.Cities.Queries;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class CitiesController : BaseApiController
    {
        IMediator _mediator;
        ILogger<CitiesController> _logger;

        public CitiesController(IMediator mediator, ILogger<CitiesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCities([FromQuery] CityListQuery query)
        {
            try
            {
                if (query == null) query = new CityListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<CityListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllCities");
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
