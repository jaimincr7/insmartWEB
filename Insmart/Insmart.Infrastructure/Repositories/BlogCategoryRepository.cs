using Insmart.Application.Interfaces;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Insmart.Infrastructure.Repositories
{
    public class BlogCategoryRepository : BaseRepository<BlogCategory>, IBlogCategoryRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<BlogCategoryRepository> _logger;

        public BlogCategoryRepository(IConfiguration configuration, ILogger<BlogCategoryRepository> logger): base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
        }
    }
}
