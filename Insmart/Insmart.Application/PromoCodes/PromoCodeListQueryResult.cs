namespace Insmart.Application.PromoCodes
{
    public class PromoCodeListQueryResult : ListQueryResult
    {
        public IEnumerable<PromoCodeDetailsQueryResult> PromoCodes { get; set; }
    }
}
