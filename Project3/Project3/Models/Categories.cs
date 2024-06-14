using Project3.Models;
using System.ComponentModel.DataAnnotations;

namespace Project3.Models
{
    public class Categries : Base
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "CategoryName is required")]
        [StringLength(100, ErrorMessage = "CategoryName cannot be longer than 100 characters")]
        public string? CategoryName { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string? Description { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }

}
