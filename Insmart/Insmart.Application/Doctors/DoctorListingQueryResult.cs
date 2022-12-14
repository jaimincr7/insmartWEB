namespace Insmart.Application.Doctors
{
    public class DoctorListingQueryResult : ListQueryResult
    {
        public IEnumerable<DoctorListingDetailsQueryResult> Doctors { get; set; }
    }
}
