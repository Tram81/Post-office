using System.ComponentModel.DataAnnotations;

namespace prj3.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string?ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityStock { get; set; }

        public virtual Product? ProductInfo { get; set; } // Sử dụng tên chính xác của lớp
    }
}

