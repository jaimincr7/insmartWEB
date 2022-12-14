using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class TestimonialRepository : BaseRepository<Testimonial>, ITestimonialRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<TestimonialRepository> _logger;

        public TestimonialRepository(IConfiguration configuration, ILogger<TestimonialRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
