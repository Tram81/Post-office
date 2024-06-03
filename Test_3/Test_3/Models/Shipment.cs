using System;
using Test_3.Models;

namespace prj3.Models
{
    public class Shipment : Base
    {
        public int ShipmentID { get; set; } // Sửa tên thuộc tính SgipmentID
        public string OrderId { get; set; } // Sửa tên thuộc tính OderId
        public DateTime DeliveryDate { get; set; } // Sửa kiểu dữ liệu của thuộc tính DelivieryDate và tên của nó
        public ShipmentStatus Status { get; set; } // Sử dụng kiểu dữ liệu của enum và tên thuộc tính Status
        public string Notes { get; set; } // Sửa kiểu dữ liệu của thuộc tính notes

        // Định nghĩa enum cho trạng thái của shipment
        public enum ShipmentStatus
        {
            Pending,
            InTransit,
            Delivered,
            Failed
        }
    }
}
