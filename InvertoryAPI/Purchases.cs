using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace InvertoryAPI
{
    public class Purchases
    {
        public int Id { get; set; }
        [Required]

        [StringLength(30)]
        public string Vendor { get; set; } = string.Empty;

        [StringLength(20)]
        public string Product_Name { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int UnitPrice { get; set; }
        public int TotalPrice { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public int SuppliersId { get; set; }
        public Suppliers? Suppliers { get; set; }
    }
}