namespace Insmart.Application.Banners
{
    public class BannerDetailsQueryResult 
    {
        public int BannerId { get; set; }
        public string BannerPath { get; set; }
        public int BannerPageType { get; set; }
        public string BannerType { get; set; }
        public int BannerRedirectType { get; set; }
        public string RedirectTo { get; set; }
        public int IsActive { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
