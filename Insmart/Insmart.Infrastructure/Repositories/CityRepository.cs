using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Core;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Insmart.Application.Cities.Queries;
using Insmart.Application.Cities;

namespace Insmart.Infrastructure.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<CityRepository> _logger;

        public CityRepository(IConfiguration configuration, ILogger<CityRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<CityListQueryResult> GetAllCitiesAsync(CityListQuery query)
        {
            var result = new CityListQueryResult();

            var whereClause = "1=1";

            DynamicParameters parameters = new DynamicParameters();

            if (query.StateId > 0)
            {
                whereClause += " AND StateId=@StateId";
                parameters.Add("StateId", query.StateId);
            }

            if (!string.IsNullOrEmpty(query.Name))
            {
                whereClause += " And Name like @Name";
                parameters.Add("Name", $"%{query.Name}%");
            }

            var dataQuery = $"SELECT * FROM cities /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM cities /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Cities = await connection.QueryAsync<CityDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }
    }
}
