using AutoMapper;
using Dapper;
using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<DoctorRepository> _logger;
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public AppointmentRepository(IConfiguration configuration, ILogger<DoctorRepository> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Doctor>> GetAllAppointmentsAsync(int promotionalId)
        {
            string query = @$"SELECT FirstName,LastName,PhotoPath,AverageRating,'' as Experiance, 
                            (SELECT GROUP_CONCAT(Name) as Speciality FROM doctor_specialities 
                            inner join specialities on specialities.SpecialityId = doctor_specialities.SpecialityId and doctor_specialities.DoctorId=doctors.DoctorId 
                            GROUP BY DoctorId) as Specilities
                         from doctors inner join promotional_items on doctors.DoctorId = promotional_items.ItemId where PromotionalId = {promotionalId}
                         and IsDeleted=0  order by DisplayOrder";

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<Doctor>(query);
            }
        }
    }
}
