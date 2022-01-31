using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingOrders.Models
{
    public class Orders
    {
        [Key]
        public string ShipperOrderId { get; set; }
        public DateTime requestedPickupTime { get; set; }      
        public string PickupInstruction { get; set; }
        public string DeiiveryInstruction { get; set; }
        public List<Items> ItemList { get; set; }    
        public virtual Address DeliveryAddress { get; set; }
        public virtual Address PickupAddress { get; set; }



    }
}
