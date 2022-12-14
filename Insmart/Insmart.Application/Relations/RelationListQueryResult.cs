namespace Insmart.Application.Relations
{
    public class RelationListQueryResult : ListQueryResult
    {
        public IEnumerable<RelationDetailsQueryResult> Relations { get; set; }
    }
}
