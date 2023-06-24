using System.ComponentModel.DataAnnotations;

namespace InvertoryAPI
{
    public class Roleaccess
    {
        public int Id { get; set; }
        [Required]

        [StringLength(30)]
        public string role { get; set; } = string.Empty;

        [StringLength(20)]
        public string menu { get; set; } = string.Empty;
        public bool haveedit { get; set; }
        public bool haveadd { get; set; }
        public bool havedelete { get; set; }
    }
}
