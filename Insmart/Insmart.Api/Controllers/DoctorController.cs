
using Insmart.Apis;
using Insmart.Application.Doctors;
using Insmart.Application.Doctors.Queries;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class DoctorsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<DoctorsController> _logger;

        public DoctorsController(IMediator mediator, ILogger<DoctorsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetDoctorNames([FromQuery] DoctorNamesListQuery query)
        {
            try
            {
                if (query == null) query = new DoctorNamesListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<DoctorNamesListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetDoctorNames");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctor(int id)
        {
            try
            {
                var data = await _mediator.Send(new DoctorDetailsQuery { Id = id });
                var response = new ApiResponse<DoctorCompleteDetailsQueryResult>(data);
                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetDoctor");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }

        [HttpPost("FilterDoctors")]
        public async Task<IActionResult> GetAllDoctors([FromBody] DoctorListQuery query)
        {
            try
            {
                if (query == null) query = new DoctorListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<DoctorListingQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllDoctors");
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
