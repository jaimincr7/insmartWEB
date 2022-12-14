using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class PromotionalRepository : BaseRepository<Promotional>, IPromotionalRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<PromotionalRepository> _logger;

        public PromotionalRepository(IConfiguration configuration, ILogger<PromotionalRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public virtual async Task<IEnumerable<Promotional>> GetAllPromotionsAsync()
        {
            string query = "select * from promotionals where IsDeleted=0";
            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Promotional>(query);
            }
        }
    }
}
