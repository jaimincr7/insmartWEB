using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Application.Hospitals.Queries;
using Insmart.Application.Hospitals;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Insmart.Core;
using AutoMapper;

namespace Insmart.Infrastructure.Repositories
{
    public class HospitalRepository : BaseRepository<Hospital>, IHospitalRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<HospitalRepository> _logger;
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public HospitalRepository(IConfiguration configuration, ILogger<HospitalRepository> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<HospitalListQueryResult> GetAllPromotionalAsync(int promotionalId)
        {
            var result = new HospitalListQueryResult();

            var whereClause = "IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            whereClause += " AND promotionalId=@promotionalId";
            parameters.Add("promotionalId", promotionalId);

            var dataQuery = $"SELECT hospitals.HospitalId,Name,(select Name from cities where CityId=hospitals.CityId limit 1) as City,(select FilePath from hospital_files where HospitalId=hospitals.HospitalId and HospitalFileType=0 order by HospitalFileId Asc limit 1) as ImagePath,(select count(*) from hospital_doctors where hospitals.HospitalId=hospital_doctors.HospitalId) as DoctorCount from hospitals inner join promotional_items on hospitals.HospitalId=promotional_items.ItemId /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                var selector = builder.AddTemplate(dataQuery);
                result.Hospitals = await connection.QueryAsync<HospitalDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }

        public async Task<HospitalListQueryResult> GetAllHospitalsAsync(HospitalListQuery query)
        {
            var result = new HospitalListQueryResult();

            var whereClause = "IsActive=1 and IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(query.Name))
            {
                whereClause += " AND (Name like @Name)";
                parameters.Add("Name", $"%{query.Name}%");
            }

            if (query.CityId > 0)
            {
                whereClause += " AND CityId=@CityId";
                parameters.Add("CityId", query.CityId);
            }

            var dataQuery = $"SELECT *,(select count(*) from hospital_doctors where hospitals.HospitalId=hospital_doctors.HospitalId) as DoctorCount FROM insmart.hospitals /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM insmart.hospitals /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Hospitals = await connection.QueryAsync<HospitalDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }

    }
}
