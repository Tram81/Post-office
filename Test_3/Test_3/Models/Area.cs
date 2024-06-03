using Test_3.Models;

namespace prj3.Models
{
    public class Area : Base
    {
        public int AreaID { get; set; }
        public string AreaName { get; set; } // Loại bỏ dấu '?' và thêm tên mô tả
        public ICollection<Area> SubAreas { get; set; } // Đổi tên của thuộc tính Areas thành SubAreas để mô tả rõ ràng hơn
    }
}
