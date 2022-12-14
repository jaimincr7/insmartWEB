using Insmart.Application.Features.Auth.Results;
using MediatR;

namespace Insmart.Application.Features.Auth.Queries
{
    public class LoginWithOTPQuery: IRequest<LoginWithOTPQueryResult>
    {
        public string MobileNumber { get; set; } = null!;
        public string OTP { get; set; } = null!;
    }
}
