namespace Insmart.Application.Specialities
{
    public class SpecialityListQueryResult : ListQueryResult
    {
        public IEnumerable<SpecialityDetailsQueryResult> Specialities { get; set; }
    }
}
