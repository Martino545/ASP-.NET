using System;
using System.Collections.Generic;

namespace Cvjecarna
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public List<Flower> Flowers { get; set; } = new List<Flower>();
    }
}