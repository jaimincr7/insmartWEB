using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<PatientRepository> _logger;

        public PatientRepository(IConfiguration configuration, ILogger<PatientRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
