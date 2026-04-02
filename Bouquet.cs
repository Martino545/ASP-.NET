using System;
using System.Collections.Generic;

namespace Cvjecarna
{
    public class Bouquet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Flower> Flowers { get; set; } = new List<Flower>();
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Occasion { get; set; }
        public DateTime CreationDate { get; set; }
    }
}