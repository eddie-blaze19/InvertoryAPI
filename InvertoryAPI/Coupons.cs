using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Coupons
    {
        public int Id { get; set; }
        [Required]

        [StringLength(20)]
        public string CouponName { get; set; } = string.Empty;

        public int Coupon { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
