using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class UserAddressRepository : BaseRepository<UserAddress>, IUserAddressRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<UserAddressRepository> _logger;

        public UserAddressRepository(IConfiguration configuration, ILogger<UserAddressRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
