using System;

namespace Cvjecarna
{
    public class Delivery
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        public Employee Employee { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Status { get; set; }
    }
}