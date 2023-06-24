using System.ComponentModel.DataAnnotations;
using System.Drawing.Drawing2D;

namespace InvertoryAPI
{
    public class Product
    { 
        public int Id { get; set; }
        [Required] 

        [StringLength(20)]
        public string Product_Name { get; set; } = string.Empty;
        [StringLength(20)]
        public string Category { get; set; } = string.Empty;
        public int SKU { get; set; }
        [StringLength(30)]
        public string Brand_Name { get; set; } = string.Empty;
        public int Items_instock { get; set; }
        [StringLength(20)]
        public string Product_Status { get; set; } = string.Empty;
        public DateTime? Update_Date { get; set; } 
        public int UnitPrice { get; set; }
        public string Description { get; set; } = string.Empty;

    }
}


