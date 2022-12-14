using Elasticsearch.Net;
using Insmart.Apis;
using Insmart.Application.Users.Commands;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Insmart.Api.Controllers
{
    public class UsersController : BaseApiController
    {
        private readonly IMediator _mediator;
        ILogger<AppointmentsController> _logger;

        public UsersController(IMediator mediator, ILogger<AppointmentsController> logger)
        {
            _mediator = mediator;
            ILogger<AppointmentsController> _logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserCommand command)
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
                _logger.LogError(ex, "CreateUser");
                ApiResponse<bool> response = new ApiResponse<bool>()
                {
                    IsSuccess = false,
                    Message = Constants.GeneralError
                };
                return StatusCode(500, response);;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddUserAddress([FromBody] CreateUserAddressCommand command)
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
                _logger.LogError(ex, "AddUserAddress");
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
