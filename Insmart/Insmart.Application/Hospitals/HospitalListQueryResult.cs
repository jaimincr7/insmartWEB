namespace Insmart.Application.Hospitals
{
    public class HospitalListQueryResult : ListQueryResult
    {
        public IEnumerable<HospitalDetailsQueryResult> Hospitals { get; set; }
    }
}
