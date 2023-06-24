using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Employees
    {
        public int Id { get; set; }
        [Required]

        [StringLength(50)]
        public string name { get; set; } = string.Empty;
        [StringLength(30)]
        public string password { get; set; } = string.Empty;

        [StringLength(30)]
        public string role { get; set; } = string.Empty;
 
        public bool isactive { get; set; }

        [StringLength(200)]
        public string Email { get; set; } = string.Empty;
        [StringLength(200)]
        public string Address { get; set; } = string.Empty;
    }
}
