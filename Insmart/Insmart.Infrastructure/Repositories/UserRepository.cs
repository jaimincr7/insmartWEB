using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(IConfiguration configuration, ILogger<UserRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
