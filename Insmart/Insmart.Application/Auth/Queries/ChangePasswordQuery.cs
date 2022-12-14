using Insmart.Application.Features.Auth.Results;
using MediatR;

namespace Insmart.Application.Features.Auth.Queries
{
    public class ChangePasswordQuery: IRequest<ChangePasswordQueryResult>
    {
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
    }
}
