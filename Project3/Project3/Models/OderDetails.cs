using Project3.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project3.Models
{
    public class OrderDetails : Base
    {
        [Key]
        public int OrderDetailsID { get; set; }

        [Required(ErrorMessage = "OrderID is required")]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "ProductID is required")]
        public int ProductID { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a non-negative integer")]
        public int Quantity { get; set; } = 0;

        [Range(0, double.MaxValue, ErrorMessage = "Price must be a non-negative value")]
        public decimal Price { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order? Order { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product? Product { get; set; }
    }

}