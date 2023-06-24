using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Sales
    {
        public int Id { get; set; }
        [Required]

        [StringLength(50)]
        public string Customer_Name { get; set; } = string.Empty;

        [StringLength(20)]
        public string Product_Name { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public DateTime? Date { get; set; }

        public int UnitPrice { get; set; }

        public int Coupon { get; set; }

        public int TotalPrice { get; set; }

        [StringLength(20)]
        public string Payment_method { get; set; } = string.Empty;


        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }

        public int CouponsId { get; set; }
        public Coupons? Coupons { get; set; }

    }
}
