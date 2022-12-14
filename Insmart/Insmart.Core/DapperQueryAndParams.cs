using Insmart.Core.DTOs;

namespace Insmart.Core
{
    public class DapperQueryAndParams<T> where T : BaseEntity
    {
        public string RawSql { get; set; }
        public T Parameters { get; set; }
    }
}
