using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShippingOrders.Models
{
    public class Items
    {
        [Key]
        public string ItemCode { get; set; }
        public int Quantity { get; set; }


    }
}
