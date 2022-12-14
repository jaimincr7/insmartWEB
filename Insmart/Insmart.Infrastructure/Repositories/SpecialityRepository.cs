using Dapper;
using Insmart.Application.Specialities.Queries;
using Insmart.Application.Specialities;
using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Insmart.Core;
using AutoMapper;

namespace Insmart.Infrastructure.Repositories
{
    public class SpecialityRepository : BaseRepository<Speciality>, ISpecialityRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<SpecialityRepository> _logger;
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public SpecialityRepository(IConfiguration configuration, ILogger<SpecialityRepository> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Speciality>> GetAllPromotionalAsync(int promotionalId)
        {
            string query = @$"SELECT specialities.SpecialityId,speciality_translations.Name,speciality_translations.Description,ImagePath from specialities inner join promotional_items on specialities.SpecialityId=promotional_items.ItemId 
                                inner join speciality_translations on specialities.SpecialityId=speciality_translations.SpecialityId
                            where PromotionalId = {promotionalId} and IsDeleted=0  order by DisplayOrder";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Speciality>(query);
            }
        }

        public async Task<SpecialityListQueryResult> GetAllSpecialitiesAsync(SpecialityListQuery query)
        {
            var result = new SpecialityListQueryResult();

            var whereClause = "s.IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            whereClause += " AND st.LanguageId=@LanguageId";
            parameters.Add("LanguageId", query.LanguageId > 0 ? query.LanguageId : Constants.Engilish);

            if (!string.IsNullOrEmpty(query.Name))
            {
                whereClause += " AND (st.Name like @Name)";
                parameters.Add("Name", $"%{query.Name}%");
            }

            var dataQuery = $"SELECT * FROM insmart.specialities s left join speciality_translations st on s.SpecialityId=st.SpecialityId /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM insmart.specialities s left join speciality_translations st on s.SpecialityId=st.SpecialityId /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Specialities = await connection.QueryAsync<SpecialityDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }
    }
}
