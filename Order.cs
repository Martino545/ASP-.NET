using System;
using System.Collections.Generic;

namespace Cvjecarna
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Bouquet> Bouquets { get; set; } = new List<Bouquet>();
        public DateTime OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public decimal TotalPrice { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Delivery Delivery { get; set; }
    }
}