using System.ComponentModel.DataAnnotations;
using Test_3.Models;

namespace prj3.Models
{
    public class Admin : Base
    {
        [Key]
        public int AdminId { get; set; }
        public string? AdminName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}
