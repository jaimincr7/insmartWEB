namespace Insmart.Application.Cities
{
    public class CityListQueryResult : ListQueryResult
    {
        public IEnumerable<CityDetailsQueryResult> Cities { get; set; }
    }
}
