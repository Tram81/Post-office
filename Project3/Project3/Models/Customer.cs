using System.ComponentModel.DataAnnotations;

namespace Project3.Models
{
    public class Customer:Base
    {
        public string? Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters")]
       
        public string? Email { get; set; }

        [StringLength(100, ErrorMessage = "FullName cannot be longer than 100 characters")]
        public string? FullName { get; set; }

        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters")]
        public string? Address { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        [StringLength(20, ErrorMessage = "Phone cannot be longer than 20 characters")]
        public string? Phone{ get; set; }

        [StringLength(50, ErrorMessage = "PaymentMethod cannot be longer than 50 characters")]
        public string? Password { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }
    }
}
