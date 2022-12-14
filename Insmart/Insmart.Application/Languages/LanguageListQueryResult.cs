namespace Insmart.Application.Languages
{
    public class LanguageListQueryResult : ListQueryResult
    {
        public IEnumerable<LanguageDetailsQueryResult> Languages { get; set; }
    }
}
