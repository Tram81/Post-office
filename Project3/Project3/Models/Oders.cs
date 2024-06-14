using Project3.Models;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Project3.Models
{
    public class Order : Base
    {
        [Key]
        public int OrderID { get; set; }

        [Required(ErrorMessage = "UserID is required")]
        public int UserID { get; set; }

        [Required(ErrorMessage = "AreaCode is required")]
        [StringLength(10, ErrorMessage = "AreaCode cannot be longer than 10 characters")]
        public string? AreaCode { get; set; }

        public DateTime? OrderDate { get; set; }

        [Required(ErrorMessage = "Status is required")]
        public OrderStatus Status { get; set; }

        [Required(ErrorMessage = "ShippingAddress is required")]
        [StringLength(200, ErrorMessage = "ShippingAddress cannot be longer than 200 characters")]
        public string? ShippingAddress { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "ShippingFee must be a non-negative value")]
        public decimal ShippingFee { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "TotalAmount must be a non-negative value")]
        public decimal TotalAmount { get; set; }

        [ForeignKey("UserID")]
        public virtual Customer? Customer { get; set; }

        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Cancelled
        }
    }

}
