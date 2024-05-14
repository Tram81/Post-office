using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace prj3.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }

        [ForeignKey("UserID")]
        public string UserID { get; set; }

        [ForeignKey("AreaID")]
        public string AreaID { get; set; }

        public DateTime? OrderDate { get; set; }

        public OrderStatus Status { get; set; }

        public string ShippingAddress { get; set; }
        public decimal? ShippingFee { get; set; }
        public decimal? TotalAmount { get; set; }

        public ICollection<Area> Areas { get; set; }

        public enum OrderStatus
        {
            Pending,
            Processing,
            Shipped,
            Cancelled
        }
    }
}
