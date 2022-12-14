namespace Insmart.Application.Doctors
{
    public class DoctorNamesListQueryResult : ListQueryResult
    {
        public IEnumerable<DoctorDetailsQueryResult> Doctors { get; set; }
    }
}
