namespace Insmart.Application.Symptoms
{
    public class SymptomListQueryResult : ListQueryResult
    {
        public IEnumerable<SymptomDetailsQueryResult> Symptoms { get; set; }
    }
}
