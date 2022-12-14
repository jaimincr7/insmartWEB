namespace Insmart.Application.Banners
{
    public class BannerListQueryResult : ListQueryResult
    {
        public IEnumerable<BannerDetailsQueryResult> Banners { get; set; }
    }
}
