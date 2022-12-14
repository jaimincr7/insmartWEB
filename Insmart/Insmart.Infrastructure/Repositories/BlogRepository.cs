using Dapper;
using Insmart.Application.Blogs.Queries;
using Insmart.Application.Blogs;
using Insmart.Application.Interfaces;
using Insmart.Core;
using Insmart.Core.DTOs;
using Insmart.InfraStructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Dapper.Contrib.Extensions;
using Insmart.Application.Doctors;
using MySqlX.XDevAPI.Common;

namespace Insmart.Infrastructure.Repositories
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        readonly IConfiguration _configuration;
        readonly ILogger<BlogRepository> _logger;
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        public BlogRepository(IConfiguration configuration, ILogger<BlogRepository> logger, IUnitOfWork unitOfWork, IMapper mapper) : base(configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<BlogListQueryResult> GetAllBlogsAsync(BlogListQuery query)
        {
            var result = new BlogListQueryResult();

            var whereClause = "IsActive=1 and IsDeleted=0";

            DynamicParameters parameters = new DynamicParameters();

            if (!string.IsNullOrEmpty(query.Title))
            {
                whereClause += " AND (Title like @Title)";
                parameters.Add("Title", $"%{query.Title}%");
            }

            if (query.BlogCategoryId > 0)
            {
                whereClause += " AND BlogCategoryId=@BlogCategoryId";
                parameters.Add("BlogCategoryId", query.BlogCategoryId);
            }


            var dataQuery = $"SELECT * FROM insmart.blogs /**where**/";
            var builder = new SqlBuilder().Where(whereClause, parameters);

            using (var connection = GetConnection())
            {
                if (query.PageNumber > 0 && query.PageSize > 0)
                {
                    dataQuery += $"limit {query.PageSize} offset {(query.PageNumber - 1) * query.PageSize}";
                    result.Pagination = new Pagination { PageNumber = query.PageNumber, PageSize = query.PageSize };
                    var counter = builder.AddTemplate($"SELECT count(*) FROM insmart.blogs /**where**/");
                    result.Pagination.TotalRecords = await connection.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                }

                var selector = builder.AddTemplate(dataQuery);
                result.Blogs = await connection.QueryAsync<BlogDetailsQueryResult>(selector.RawSql, selector.Parameters);
            }

            return result;
        }

        public async Task<BlogDetailsQueryResult> GetBlogDetailsAsync(int blogId)
        {

            var dataQuery = $"SELECT *,(select max(BlogId) from blogs where BlogId < {blogId}) as PrevBlogId,(select min(BlogId) from blogs where BlogId > {blogId}) as NextBlogId FROM insmart.blogs where BlogId={blogId} and IsDeleted=0 and IsActive=1";
            var builder = new SqlBuilder();

            using (var connection = GetConnection())
            {
                var selector = builder.AddTemplate(dataQuery);
                return await connection.QueryFirstOrDefaultAsync<BlogDetailsQueryResult>(selector.RawSql);
            }

        }
    }
}
