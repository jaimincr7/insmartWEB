using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    public class BaseEntity
    {
        [Computed]
        [Write(false)]
        public int RowNumber { get; set; }
        [Computed]
        [Write(false)]
        public int TotalRecords { get; set; }
    }
}
