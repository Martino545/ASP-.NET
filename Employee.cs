using System;
using System.Collections.Generic;

namespace Cvjecarna
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Role { get; set; }
        public List<Delivery> Deliveries { get; set; } = new List<Delivery>();
    }
}