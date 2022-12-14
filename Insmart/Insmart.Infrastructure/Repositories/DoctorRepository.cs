using Dapper;
using Insmart.Application.Doctors.Queries;
using Insmart.Application.Doctors;
using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Insmart.Core;
using AutoMapper;

namespace Insmart.Infrastructure.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IDoctorRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<DoctorRepository> _logger;
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public DoctorRepository(IConfiguration configuration, ILogger<DoctorRepository> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<DoctorNamesListQueryResult> GetAllPromotionalAsync(int promotionalId)
        {
            var result = new DoctorNamesListQueryResult();

            var whereClause = "IsActive=1 and IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            whereClause += " AND promotionalId=@promotionalId";
            parameters.Add("promotionalId", promotionalId);

            var dataQuery = $"SELECT doctors.DoctorId,FirstName,LastName,PhotoPath,AverageRating,YearsOfExperience,(select Name from cities where CityId=doctors.CityId limit 1) as City, (SELECT GROUP_CONCAT(speciality_translations.Name) as Speciality FROM doctor_specialities inner join specialities on specialities.SpecialityId = doctor_specialities.SpecialityId and doctor_specialities.DoctorId=doctors.DoctorId inner join speciality_translations on doctor_specialities.SpecialityId=speciality_translations.SpecialityId GROUP BY DoctorId) as Specilities from doctors inner join promotional_items on doctors.DoctorId = promotional_items.ItemId /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                var selector = builder.AddTemplate(dataQuery);
                result.Doctors = await connection.QueryAsync<DoctorDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }

        public async Task<DoctorNamesListQueryResult> GetHomePageDoctorsAsync(DoctorNamesListQuery request)
        {
            var result = new DoctorNamesListQueryResult();

            DapperQueryAndParams<Doctor> where = new DapperQueryAndParams<Doctor>()
            {
                Parameters = new Doctor { }
            };

            where.RawSql = "IsDeleted=0 and IsActive=1";

            if (!string.IsNullOrEmpty(request.Name))
            {
                where.RawSql += " AND (FirstName like @FirstName OR  LastName like @LastName)";
                where.Parameters.FirstName = $"%{request.Name}%";
                where.Parameters.LastName = $"%{request.Name}%";
            }

            IEnumerable<Doctor> items;

            if (request.PageNumber > 0 && request.PageSize > 0)
            {
                result.Pagination = new Pagination { PageNumber = request.PageNumber, PageSize = request.PageSize };
                items = await _unitOfWork.Doctors.GetAllAsync(where, "DoctorId desc", result.Pagination);
            }
            else
            {
                items = await _unitOfWork.Doctors.GetAllAsync(where, "DoctorId desc");
            }

            result.Doctors = _mapper.Map<IEnumerable<Doctor>, IEnumerable<DoctorDetailsQueryResult>>(items);

            return result;
        }

        public async Task<DoctorListingQueryResult> GetDoctorListAsync(DoctorListQuery query)
        {
            var result = new DoctorListingQueryResult();

            var whereClause = "doctors.IsDeleted=0 and doctors.IsActive=1";

            DynamicParameters parameters = new DynamicParameters();

            if (query.DoctorId > 0)
            {
                whereClause += "  AND doctors.DoctorId=@DoctorId";
                parameters.Add("DoctorId", query.DoctorId);
            }
            else
            {
                if (query.CityId>0)
                {
                    whereClause += "  AND doctors.CityId=@CityId";
                    parameters.Add("CityId", query.CityId);
                }

                if (!string.IsNullOrEmpty(query.Gender))
                {
                    whereClause += "  AND doctors.Gender=@Gender";
                    parameters.Add("Gender", query.Gender);
                }

                if (query.Hospitals != null && query.Hospitals.Length > 0)
                {
                    whereClause += "  AND HospitalId in(@HospitalIds)";
                    parameters.Add("HospitalIds", String.Join(",", query.Hospitals));
                }

                if (query.Specialities != null && query.Specialities.Length > 0)
                {
                    whereClause += "  AND SpecialityId in(@SpecialityIds)";
                    parameters.Add("SpecialityIds", String.Join(",", query.Specialities));
                }

                if (query.Symptoms != null && query.Symptoms.Length > 0)
                {
                    whereClause += "  AND SymptomId in(@SymptomIds)";
                    parameters.Add("SymptomIds", String.Join(",", query.Symptoms));
                }

                if (query.Languages != null && query.Languages.Length > 0)
                {
                    whereClause += "  AND LanguageId in(@LanguageIds)";
                    parameters.Add("LanguageIds", String.Join(",", query.Languages));
                }

                if (query.ServiceTypes != null && query.ServiceTypes.Length > 0)
                {
                    whereClause += "  AND ServiceTypeId in(@ServiceTypeIds)";
                    parameters.Add("ServiceTypeIds", String.Join(",", query.ServiceTypes));
                }

                if (query.MinExperiances > 0)
                {
                    whereClause += "  AND doctors.YearsOfExperience>@MinExperiances";
                    parameters.Add("MinExperiances", query.MinExperiances);
                }

                if (query.MaxExperiances > 0)
                {
                    whereClause += "  AND doctors.YearsOfExperience<@MaxExperiances";
                    parameters.Add("MaxExperiances", query.MaxExperiances);
                }
            }

            var dataQuery = @$"SELECT distinct doctors.DoctorId,FirstName,LastName,PhotoPath,AverageRating,TotalRatings,YearsOfExperience, (select Name from cities where CityId=doctors.CityId limit 1) as City,
            (SELECT GROUP_CONCAT(Name) as Languages FROM doctor_languages left join languages on languages.LanguageId= doctor_languages.LanguageId where doctor_languages.DoctorId=doctors.DoctorId  GROUP BY DoctorId) as Languages,
            (SELECT GROUP_CONCAT(Name) as Speciality FROM doctor_specialities left join specialities on specialities.SpecialityId = doctor_specialities.SpecialityId where doctor_specialities.DoctorId=doctors.DoctorId  GROUP BY DoctorId) as Specilities
            from doctors
            left join doctor_languages on doctors.DoctorId=doctor_languages.DoctorId
            left join doctor_specialities on doctors.DoctorId=doctor_specialities.DoctorId
            left join doctor_symptoms on doctors.DoctorId=doctor_symptoms.DoctorId
            left join hospital_doctors on doctors.DoctorId=hospital_doctors.DoctorId
            left join doctor_service_types on doctors.DoctorId=doctor_service_types.DoctorId /**where**/  /**orderby**/";

            var builder = new SqlBuilder().Where(whereClause, parameters).OrderBy("AverageRating " + query.OrderBy);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate(dataQuery);
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Doctors = await connection.QueryAsync<DoctorListingDetailsQueryResult>(selector.RawSql, selector.Parameters);

            }

            return result;
        }

        public async Task<DoctorDetailsQueryResult> GetDoctorDetailsAsync(int doctorId)
        {
            var dataQuery = new DapperQueryAndParams<Doctor>()
            {
                RawSql = $"DoctorId={doctorId} and IsDeleted=0 and IsActive=1"
            };

            var result = await _unitOfWork.Doctors.GetAsync(dataQuery);
            return _mapper.Map<DoctorDetailsQueryResult>(result);
        }

        public async Task<IEnumerable<Language>> GetDoctorLanguagesAsync(int doctorId)
        {
            string query = @$"select * from languages left join doctor_languages on languages.languageId=doctor_languages.languageId where doctor_languages.doctorId={doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Language>(query);
            }
        }

        public async Task<IEnumerable<Speciality>> GetDoctorSpecialitiesAsync(int doctorId)
        {
            string query = @$"select * from specialities left join doctor_specialities on specialities.SpecialityId=doctor_specialities.SpecialityId  where doctor_specialities.doctorId={doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Speciality>(query);
            }
        }

        public async Task<IEnumerable<DoctorEducation>> GetDoctorEducationsAsync(int doctorId)
        {
            string query = @$"select * from doctor_educations where doctorID= {doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<DoctorEducation>(query);
            }
        }

        public async Task<IEnumerable<DoctorAward>> GetDoctorAwardsAsync(int doctorId)
        {
            string query = @$"SELECT * FROM doctor_awards where DoctorId = {doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<DoctorAward>(query);
            }
        }

        public async Task<IEnumerable<AppointmentReview>> GetDoctorPatientFeedbackAsync(int doctorId)
        {
            string query = @$"SELECT * FROM appointment_reviews where DoctorId = {doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<AppointmentReview>(query);
            }
        }

        public async Task<IEnumerable<Hospital>> GetDoctorHospitalsAsync(int doctorId)
        {
            string query = @$"SELECT * FROM hospital_doctors left join hospitals on hospital_doctors.HospitalId=hospitals.HospitalId where DoctorId= {doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Hospital>(query);
            }
        }

        public async Task<IEnumerable<DoctorExperience>> GetDoctorExperiancesAsync(int doctorId)
        {
            string query = @$"SELECT * FROM doctor_experiences where DoctorId = {doctorId}";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<DoctorExperience>(query);
            }
        }
    }
}
