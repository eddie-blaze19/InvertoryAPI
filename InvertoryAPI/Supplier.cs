using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Suppliers
    {
        public int Id { get; set; }
        [Required]

        [StringLength(30)]
        public string Supplier { get; set; } = string.Empty;
        public int Phone_no { get; set; }
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;
    }
}
