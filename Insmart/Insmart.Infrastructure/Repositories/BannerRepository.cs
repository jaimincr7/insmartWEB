using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Banners.Queries;
using Insmart.Application.Banners;
using Insmart.Core;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class BannerRepository : BaseRepository<Banner>, IBannerRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<BannerRepository> _logger;

        public BannerRepository(IConfiguration configuration, ILogger<BannerRepository> logger) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<BannerListQueryResult> GetAllBannersAsync(BannerListQuery query)
        {
            var result = new BannerListQueryResult();

            var whereClause = "b.IsActive=1";

            DynamicParameters parameters = new DynamicParameters();

            whereClause += " AND bt.LanguageId=@LanguageId";
            parameters.Add("LanguageId", query.LanguageId > 0 ? query.LanguageId : Constants.Engilish);

            whereClause += " AND b.BannerType=@BannerType";
            parameters.Add("BannerType", query.BannerType == null ? 0 : query.BannerType);


            var dataQuery = $"SELECT * FROM insmart.banners b left join banner_translations bt on b.BannerId=bt.BannerId /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM insmart.banners b left join banner_translations bt on b.BannerId=bt.BannerId /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Banners = await connection.QueryAsync<BannerDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }
    }
}
