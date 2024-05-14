using System.ComponentModel.DataAnnotations;

namespace prj3.Models
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
