using Insmart.Core;
using MediatR;

namespace Insmart.Application.Doctors.Queries
{
    public class DoctorListQuery : PaginationFilter, IRequest<DoctorListingQueryResult>
    {
        public int? CityId { get; set; }
        public string? Gender { get; set; }
        public string? OrderBy { get; set; }
        public int? DoctorId { get; set; }
        public string[]? Hospitals { get; set; }
        public string[]? Languages { get; set; }
        public string[]? Specialities { get; set; }
        public string[]? Symptoms { get; set; }
        public int MinExperiances { get; set; }
        public int MaxExperiances { get; set; }
        public string[]? ServiceTypes { get; set; }

        public DoctorListQuery() { }

        public DoctorListQuery(int pageIndex, int pageSize)
        {
            PageNumber = pageIndex;
            PageSize = pageSize;
        }
    }
}
