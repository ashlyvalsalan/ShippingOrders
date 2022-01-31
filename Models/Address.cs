using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShippingOrders.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public string Unit { get; set; }
        public string Street { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        //public List<Orders> Orders { get; set; }
        //[InverseProperty("DeliveryAddress")]
        //public virtual ICollection<Orders> DeliveryAddress { get; set; }
       // [InverseProperty("PickupAddress")]
        //public virtual ICollection<Orders> PickupAddress { get; set; }

    }
}
