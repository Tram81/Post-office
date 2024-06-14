using Project3.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Project3.Models
{
    public class Product : Base
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "ProductName is required")]
        [StringLength(100, ErrorMessage = "ProductName cannot be longer than 100 characters")]
        public string? ProductName { get; set; }

        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters")]
        public string? Description { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative value")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "QuantityStock must be a non-negative integer")]
        public int QuantityStock { get; set; }

        [Required(ErrorMessage = "CategoryID is required")]
        public int CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public virtual Categries? Category { get; set; }
    }


}
