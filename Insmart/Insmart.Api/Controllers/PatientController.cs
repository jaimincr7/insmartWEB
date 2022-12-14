
using Insmart.Apis;
using Insmart.Application.Patients.Commands;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class PatientsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<PatientsController> _logger;

        public PatientsController(IMediator mediator, ILogger<PatientsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpPost("add-patient")]
        public async Task<IActionResult> CreatePatient([FromBody] CreatePatientCommand command)
        {
            try
            {
                command.CreatedAt = CurrentDateTime();
                var data = await _mediator.Send(command);
                var response = new ApiResponse<int>(data);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "CreatePatient");
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
