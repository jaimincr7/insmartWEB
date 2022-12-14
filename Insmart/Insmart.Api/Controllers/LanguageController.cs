
using Insmart.Apis;
using Insmart.Application.Languages;
using Insmart.Application.Languages.Queries;
using Insmart.Core;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Insmart.Api.Controllers
{
    public class LanguagesController : BaseApiController
    {
        IMediator _mediator;
        ILogger<LanguagesController> _logger;

        public LanguagesController(IMediator mediator, ILogger<LanguagesController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllLanguages([FromQuery] LanguageListQuery query)
        {
            try
            {
                if (query == null) query = new LanguageListQuery();
                var data = await _mediator.Send(query);
                var response = new ApiResponse<LanguageListQueryResult>(data);

                return Ok(response);
            }
            catch (Exception ex)
            {
               _logger.LogError(ex, "GetAllLanguages");
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
