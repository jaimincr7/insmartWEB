using Insmart.Core;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace Insmart.Apis
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiVersion("1")]
    public class BaseApiController : ControllerBase
    {
        internal DateTime CurrentDateTime()
        {
            return DateTime.UtcNow;
        }
        internal int GetDefaultLanguageId()
        {
            return Constants.Engilish;
        }
    }
}
