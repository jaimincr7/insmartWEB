using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Symptoms.Queries;
using Insmart.Application.Symptoms;
using Insmart.Core;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class SymptomRepository : BaseRepository<Symptom>, ISymptomRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<SymptomRepository> _logger;

        public SymptomRepository(IConfiguration configuration, ILogger<SymptomRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }

        public async Task<IEnumerable<Symptom>> GetAllPromotionalAsync(int promotionalId)
        {
            string query = @$"SELECT symptoms.SymptomId,symptom_translations.Name,symptom_translations.Description,ImagePath from symptoms inner join promotional_items on symptoms.SymptomId=promotional_items.ItemId
                        inner join symptom_translations on symptoms.SymptomId=symptom_translations.SymptomId
                        where PromotionalId={promotionalId} and IsDeleted=0  order by DisplayOrder";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Symptom>(query);
            }
        }

        public async Task<SymptomListQueryResult> GetAllSymptomsAsync(SymptomListQuery query)
        {
            var result = new SymptomListQueryResult();

            var whereClause = "s.IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            whereClause += " AND st.LanguageId=@LanguageId";
            parameters.Add("LanguageId", query.LanguageId > 0 ? query.LanguageId : Constants.Engilish);


            var dataQuery = $"SELECT * FROM insmart.symptoms s left join symptom_translations st on s.SymptomId=st.SymptomId /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM insmart.symptoms s left join symptom_translations st on s.SymptomId=st.SymptomId /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Symptoms = await connection.QueryAsync<SymptomDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }
    }
}
