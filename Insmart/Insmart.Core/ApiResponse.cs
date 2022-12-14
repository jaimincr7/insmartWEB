namespace Insmart.Core
{
    public class ApiResponse<T>
    {
        public ApiResponse()
        {
        }
        public ApiResponse(T data)
        {
            IsSuccess = true;
            Message = string.Empty;
            Errors = null;
            Data = data;
        }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public List<string>? Errors { get; set; }
        public T? Data { get; set; }
    }

    public class PaginationFilter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        //public bool IncludePaginationDetail { get; set; }
    }
}
