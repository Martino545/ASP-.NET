using System;
using System.Collections.Generic;

namespace Cvjecarna
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int LoyaltyPoints { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}