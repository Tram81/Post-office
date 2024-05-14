using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace prj3.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? Fullname { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? FamenMethod { get; set; }

        // Sửa tên thuộc tính và kiểu dữ liệu của mối quan hệ
        public ICollection<Order> Orders { get; set; }
    }
}
