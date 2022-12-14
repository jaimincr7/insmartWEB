using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class UerOTPRepository : BaseRepository<UserOTP>, IUserOTPRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ILogger<UerOTPRepository> _logger;

        public UerOTPRepository(IConfiguration configuration, ILogger<UerOTPRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
