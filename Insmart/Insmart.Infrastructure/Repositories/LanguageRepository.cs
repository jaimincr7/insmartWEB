using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<LanguageRepository> _logger;

        public LanguageRepository(IConfiguration configuration, ILogger<LanguageRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
