using Insmart.Apis;
using Insmart.Application.Features.Auth.Queries;
using Insmart.Application.Features.Auth.Results;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Cms;

namespace Insmart.Api.Controllers
{
    public class AuthController : BaseApiController
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginQuery query)
        {
            var data = await _mediator.Send(query);
            var response = new ApiResponse<LoginQueryResult>();
            if (data == null)
            {
                response.IsSuccess = false;
                response.Message = "Invalid username or password";
            }
            else
            {
                response.IsSuccess = true;
                response.Data = data;
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> LoginWithOTP([FromBody] LoginWithOTPQuery query)
        {
            var data = await _mediator.Send(query);
            var response = new ApiResponse<LoginWithOTPQueryResult>();
            if (data == null)
            {
                response.IsSuccess = false;
                response.Message = "Invalid mobile number or OTP";
            }
            else
            {
                response.IsSuccess = true;
                response.Data = data;
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> RequestOTP([FromBody] RequestOTPQuery query)
        {
            var data = await _mediator.Send(query);
            var response = new ApiResponse<RequestOTPQueryResult>();
            if (data.OTP == null)
            {
                response.IsSuccess = false;
                response.Message = "Invalid mobile number";
            }
            else
            {
                response.IsSuccess = true;
                response.Data = data;
            }

            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordQuery query)
        {
            var data = await _mediator.Send(query);
            var response = new ApiResponse<ChangePasswordQueryResult>();
            if (data == null)
            {
                response.IsSuccess = false;
                response.Message = "Invalid mobile number or email";
            }
            else
            {
                response.IsSuccess = true;
                response.Data = data;
            }

            return Ok(response);
        }

    }
}
