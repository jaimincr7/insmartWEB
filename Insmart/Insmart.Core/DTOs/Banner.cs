using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("banners")]
    public class Banner : BaseEntity
    {
        [Key]
        public int BannerId { get; set; }
        public string BannerPath { get; set; }
        public int BannerPageType { get; set; }
        public string BannerType { get; set; }
        public int BannerRedirectType { get; set; }
        public string RedirectTo { get; set; }
        public bool IsActive { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
