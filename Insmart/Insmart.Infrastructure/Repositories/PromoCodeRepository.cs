using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class PromoCodeRepository : BaseRepository<PromoCode>, IPromoCodeRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<PromoCodeRepository> _logger;

        public PromoCodeRepository(IConfiguration configuration, ILogger<PromoCodeRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

    }
}
