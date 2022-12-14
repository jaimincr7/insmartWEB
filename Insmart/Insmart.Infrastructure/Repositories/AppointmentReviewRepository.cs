using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class AppointmentReviewRepository : BaseRepository<AppointmentReview>, IAppointmentReviewRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<AppointmentReviewRepository> _logger;

        public AppointmentReviewRepository(IConfiguration configuration, ILogger<AppointmentReviewRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
