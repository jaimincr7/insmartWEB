using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class RelationRepository : BaseRepository<Relation>, IRelationRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<RelationRepository> _logger;

        public RelationRepository(IConfiguration configuration, ILogger<RelationRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
