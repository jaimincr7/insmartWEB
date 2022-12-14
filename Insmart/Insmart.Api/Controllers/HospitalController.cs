
using Insmart.Application.Hospitals.Queries;
using Insmart.Application.Hospitals;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Insmart.Apis;

namespace Insmart.Api.Controllers
{
    public class HospitalsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<HospitalsController> _logger;

        public HospitalsController(IMediator mediator, ILogger<HospitalsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllHospitals([FromQuery] HospitalListQuery query)
        {
            try
            {
                if (query == null) query = new HospitalListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<HospitalListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllHospitals");
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
