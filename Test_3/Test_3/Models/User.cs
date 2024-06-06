using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Test_3.Models;

namespace prj3.Models
{
    public class User : Base
    {
        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage = "UserName is required")]
        [StringLength(100, ErrorMessage = "UserName cannot be longer than 100 characters")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, ErrorMessage = "Password cannot be longer than 100 characters")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100, ErrorMessage = "Email cannot be longer than 100 characters")]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "FullName cannot be longer than 100 characters")]
        public string FullName { get; set; }

        [StringLength(200, ErrorMessage = "Address cannot be longer than 200 characters")]
        public string Address { get; set; }

        [Phone(ErrorMessage = "Invalid phone number format")]
        [StringLength(20, ErrorMessage = "Phone cannot be longer than 20 characters")]
        public string Phone { get; set; }

        [StringLength(50, ErrorMessage = "PaymentMethod cannot be longer than 50 characters")]
        public string PaymentMethod { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }

}
