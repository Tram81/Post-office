using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace prj3.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }
        public string? OrderID { get; set; }
        public int? ProductID { get; set; }
        public int? Quantity { get; set; } = 0;
        public decimal? Price { get; set; }

        public virtual OrderDetails? Order { get; set; } // Sử dụng tên chính xác của lớp Order

        public ICollection<Product>? Products { get; set; } // Định nghĩa mối quan hệ với Product
    }
}
        
        

