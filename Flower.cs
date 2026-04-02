using System;

namespace Cvjecarna
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FlowerType Type { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public string Description { get; set; }
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
    }
}