using InvertoryAPI;
using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]

        [StringLength(50)]
        public string Customer_Name { get; set; } = string.Empty;
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
        public int Phone_no { get; set; }
        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;

    }
}			