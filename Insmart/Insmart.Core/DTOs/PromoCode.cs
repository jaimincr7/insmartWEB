using Dapper.Contrib.Extensions;

namespace Insmart.Core.DTOs
{
    [Table("promocodes")]
    public class PromoCode : BaseEntity
    {
        [Key]
        public int PromoCodeId { get; set; }
        public string Promocode { get; set; }
        public int NumberOfUsers { get; set; }
        public string PromocodeImagePath { get; set; }
        public string PromocodeBannerImagePath { get; set; }
        public string Title { get; set; }
        public string ShortText { get; set; }
        public string Description { get; set; }
        public string TermsAndConditions { get; set; }
        public int PromocodeDiscountOptionType { get; set; }
        public Decimal Discount { get; set; }
        public decimal MaxDiscountAmount { get; set; }
        public decimal MinConsultationAmount { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime ExpiryDateTime { get; set; }
        public int RedemptionLimitType { get; set; }
        public int NumberOfRedemptionLimit { get; set; }
        public int PromocodeUserSelectionType { get; set; }
        public DateTime RegisteredStartDate { get; set; }
        public DateTime RegisteredEndDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
    }
}
