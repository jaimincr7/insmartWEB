using Dapper;
using Dapper.Contrib.Extensions;
using Insmart.Application.Interfaces;
using Insmart.Core;
using Insmart.Core.DTOs;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace Insmart.InfraStructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        IConfiguration _config;
        public BaseRepository(IConfiguration config)
        {
            _config = config;
        }

        protected IDbConnection GetConnection()
        {
            return new MySqlConnection(_config["InsmartDBConnection"]);
        }

        public virtual async Task<long> AddAsync(T entity)
        {
            using (var cn = GetConnection())
            {
                return await cn.InsertAsync(entity);
            }
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            using (var cn = GetConnection())
            {
                return await cn.DeleteAsync(entity);
            }
        }

        public virtual async Task<T> GetAsync(long entityID)
        {
            using (var cn = GetConnection())
            {
                return await cn.GetAsync<T>(entityID);
            }
        }

        public async Task<T> GetAsync(DapperQueryAndParams<T> where)
        {
            var builder = new SqlBuilder().Where(where.RawSql, where.Parameters);
            string tableName = ((TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0]).Name;

            string whereClause = !string.IsNullOrWhiteSpace(where.RawSql) ? "/**where**/" : "";
            var selector = builder.AddTemplate($"select * from {tableName} {whereClause}");

            using (var connection = GetConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<T>(selector.RawSql, selector.Parameters);
            }
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var cn = GetConnection())
            {
                return await cn.GetAllAsync<T>();
            }
        }

        public virtual async Task<bool> UpdateAsync(T entity)
        {
            using (var cn = GetConnection())
            {
                return await cn.UpdateAsync(entity);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where)
        {
            var builder = new SqlBuilder().Where(where.RawSql, where.Parameters);
            string tableName = ((TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0]).Name;
            string whereClause = !string.IsNullOrWhiteSpace(where.RawSql) ? "/**where**/" : "";
            var selector = builder.AddTemplate($"select * from {tableName} {whereClause}");

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<T>(selector.RawSql, selector.Parameters);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where, string orderBy)
        {
            var builder = new SqlBuilder().Where(where.RawSql, where.Parameters).OrderBy(orderBy);
            string tableName = ((TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0]).Name;
            var selector = builder.AddTemplate($"select * from {tableName} /**where**/  /**orderby**/");

            using (var cn = GetConnection())
            {
                return await cn.QueryAsync<T>(selector.RawSql, selector.Parameters);
            }
        }

        public async Task<IEnumerable<T>> GetAllAsync(DapperQueryAndParams<T> where, string orderBy, Pagination pagination)
        {
            var builder = new SqlBuilder().Where(where.RawSql, where.Parameters).OrderBy(orderBy);
            string tableName = ((TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0]).Name;
            var selector = builder.AddTemplate($"select * from {tableName} /**where**/  /**orderby**/ limit {pagination.PageSize} offset {(pagination.PageNumber - 1) * pagination.PageSize}");
            var counter = builder.AddTemplate($"select count(*) from {tableName} /**where**/");

            using (var cn = GetConnection())
            {
                pagination.TotalRecords = await cn.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
                return await cn.QueryAsync<T>(selector.RawSql, selector.Parameters);
            }
        }

        public async Task<int> Count()
        {
            using (var cn = GetConnection())
            {
                string query = $"select count(*) from {typeof(T).Name}";
                return await cn.ExecuteScalarAsync<int>(query);
            }
        }

        public async Task<int> Count(DapperQueryAndParams<T> where)
        {
            var builder = new SqlBuilder().Where(where.RawSql, where.Parameters);
            string tableName = ((TableAttribute)typeof(T).GetCustomAttributes(typeof(TableAttribute), true)[0]).Name;
            var counter = builder.AddTemplate($"select count(*) from {tableName} /**where**/");

            using (var cn = GetConnection())
            {
                return await cn.ExecuteScalarAsync<int>(counter.RawSql, counter.Parameters);
            }
        }
    }
}
