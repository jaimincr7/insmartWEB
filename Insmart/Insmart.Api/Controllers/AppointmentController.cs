
using Insmart.Apis;
using Insmart.Application.Appointments;
using Insmart.Application.Appointments.Commands;
using Insmart.Application.Appointments.Queries;
using Insmart.Application.Users.Commands;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class AppointmentsController : BaseApiController
    {
        IMediator _mediator;
        ILogger<AppointmentsController> _logger;

        public AppointmentsController(IMediator mediator, ILogger<AppointmentsController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAppointments([FromQuery] AppointmentListQuery query)
        {
            try
            {
                if (query == null) query = new AppointmentListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<AppointmentListQueryResult>(data);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "GetAllAppointments");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);
            }
        }

        [HttpPost]
        public async Task<IActionResult> MakeAppointment([FromBody] CreateAppointmentCommand command)
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
                _logger.LogError(ex, "CreateAppointment");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddAppointmentReview([FromBody] CreateAppointmentReviewCommand command)
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
                _logger.LogError(ex, "AddAppointmentReview");
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
