using Insmart.Application.Features.Auth.Results;
using MediatR;

namespace Insmart.Application.Features.Auth.Queries
{
    public class RequestOTPQuery: IRequest<RequestOTPQueryResult>
    {
        public string Username { get; set; } = null!;
    }
}
