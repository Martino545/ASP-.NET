using System;
using System.Collections.Generic;
using System.Linq;

namespace Cvjecarna
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kreiranje dobavljača
            var supplier1 = new Supplier { Id = 1, Name = "Cvjetni Dobavljač", ContactInfo = "contact@supplier.com" };
            var supplier2 = new Supplier { Id = 2, Name = "Zeleni Vrt", ContactInfo = "info@zelenivrt.com" };

            // Kreiranje cvijeća
            var flower1 = new Flower { Id = 1, Name = "Crvena Ruža", Type = FlowerType.Rose, Color = "Crvena", Price = 5.00m, StockQuantity = 100, Description = "Ljepota u cvatu", SupplierId = 1, Supplier = supplier1 };
            var flower2 = new Flower { Id = 2, Name = "Žuti Tulipan", Type = FlowerType.Tulip, Color = "Žuta", Price = 3.50m, StockQuantity = 150, Description = "Sunčani cvijet", SupplierId = 1, Supplier = supplier1 };
            var flower3 = new Flower { Id = 3, Name = "Bijela Ljiljan", Type = FlowerType.Lily, Color = "Bijela", Price = 7.00m, StockQuantity = 80, Description = "Elegantan i mirisan", SupplierId = 2, Supplier = supplier2 };
            var flower4 = new Flower { Id = 4, Name = "Roza Orhideja", Type = FlowerType.Orchid, Color = "Roza", Price = 12.00m, StockQuantity = 50, Description = "Egzotična ljepota", SupplierId = 2, Supplier = supplier2 };

            supplier1.Flowers.Add(flower1);
            supplier1.Flowers.Add(flower2);
            supplier2.Flowers.Add(flower3);
            supplier2.Flowers.Add(flower4);

            // Kreiranje buketa
            var bouquet1 = new Bouquet
            {
                Id = 1,
                Name = "Romantični Buket",
                Flowers = new List<Flower> { flower1, flower2 },
                Price = 25.00m,
                Description = "Idealno za Valentinovo",
                Occasion = "Valentinovo",
                CreationDate = DateTime.Now.AddDays(-10)
            };
            var bouquet2 = new Bouquet
            {
                Id = 2,
                Name = "Proljetni Buket",
                Flowers = new List<Flower> { flower2, flower3 },
                Price = 30.00m,
                Description = "Svjež i živahan",
                Occasion = "Proljeće",
                CreationDate = DateTime.Now.AddDays(-5)
            };
            var bouquet3 = new Bouquet
            {
                Id = 3,
                Name = "Luksuzni Buket",
                Flowers = new List<Flower> { flower1, flower4 },
                Price = 50.00m,
                Description = "Za posebne prilike",
                Occasion = "Rođendan",
                CreationDate = DateTime.Now.AddDays(-2)
            };

            // Kreiranje kupaca
            var customer1 = new Customer
            {
                Id = 1,
                Name = "Ana",
                Surname = "Anić",
                Email = "ana.anic@email.com",
                Phone = "0912345678",
                Address = "Ulica 1, Zagreb",
                RegistrationDate = DateTime.Now.AddMonths(-6),
                LoyaltyPoints = 150
            };
            var customer2 = new Customer
            {
                Id = 2,
                Name = "Marko",
                Surname = "Marković",
                Email = "marko.markovic@email.com",
                Phone = "0923456789",
                Address = "Ulica 2, Zagreb",
                RegistrationDate = DateTime.Now.AddMonths(-3),
                LoyaltyPoints = 80
            };
            var customer3 = new Customer
            {
                Id = 3,
                Name = "Ivana",
                Surname = "Ivanić",
                Email = "ivana.ivanic@email.com",
                Phone = "0934567890",
                Address = "Ulica 3, Zagreb",
                RegistrationDate = DateTime.Now.AddMonths(-1),
                LoyaltyPoints = 50
            };

            // Kreiranje zaposlenika
            var employee1 = new Employee { Id = 1, Name = "Petar", Surname = "Petrović", Role = "Dostavljač" };
            var employee2 = new Employee { Id = 2, Name = "Marija", Surname = "Marić", Role = "Cvjećarka" };

            // Kreiranje narudžbi (3 glavna objekta)
            var order1 = new Order
            {
                Id = 1,
                Customer = customer1,
                Bouquets = new List<Bouquet> { bouquet1, bouquet2 },
                OrderDate = DateTime.Now.AddDays(-7),
                Status = OrderStatus.Delivered,
                TotalPrice = bouquet1.Price + bouquet2.Price,
                DeliveryAddress = customer1.Address,
                DeliveryDate = DateTime.Now.AddDays(-6)
            };
            var order2 = new Order
            {
                Id = 2,
                Customer = customer2,
                Bouquets = new List<Bouquet> { bouquet3 },
                OrderDate = DateTime.Now.AddDays(-3),
                Status = OrderStatus.Processing,
                TotalPrice = bouquet3.Price,
                DeliveryAddress = customer2.Address,
                DeliveryDate = DateTime.Now.AddDays(-1)
            };
            var order3 = new Order
            {
                Id = 3,
                Customer = customer3,
                Bouquets = new List<Bouquet> { bouquet1, bouquet3 },
                OrderDate = DateTime.Now.AddDays(-1),
                Status = OrderStatus.Pending,
                TotalPrice = bouquet1.Price + bouquet3.Price,
                DeliveryAddress = customer3.Address,
                DeliveryDate = DateTime.Now.AddDays(1)
            };

            customer1.Orders.Add(order1);
            customer2.Orders.Add(order2);
            customer3.Orders.Add(order3);

            // Kreiranje dostava
            var delivery1 = new Delivery
            {
                Id = 1,
                Order = order1,
                Employee = employee1,
                DeliveryDate = order1.DeliveryDate,
                Status = "Dostavljeno"
            };
            var delivery2 = new Delivery
            {
                Id = 2,
                Order = order2,
                Employee = employee1,
                DeliveryDate = order2.DeliveryDate,
                Status = "U tijeku"
            };
            var delivery3 = new Delivery
            {
                Id = 3,
                Order = order3,
                Employee = employee2,
                DeliveryDate = order3.DeliveryDate,
                Status = "Čeka"
            };

            order1.Delivery = delivery1;
            order2.Delivery = delivery2;
            order3.Delivery = delivery3;

            employee1.Deliveries.Add(delivery1);
            employee1.Deliveries.Add(delivery2);
            employee2.Deliveries.Add(delivery3);

            // Lista narudžbi za LINQ upite
            var orders = new List<Order> { order1, order2, order3 };

            // LINQ upiti

            // 1. Pronađi sve narudžbe kupca s ID 1
            var ordersByCustomer1 = orders.Where(o => o.Customer.Id == 1);
            Console.WriteLine("Narudžbe kupca Ana Anić:");
            foreach (var order in ordersByCustomer1)
            {
                Console.WriteLine($"Narudžba ID: {order.Id}, Status: {order.Status}, Ukupna cijena: {order.TotalPrice}");
            }

            // 2. Ukupna prodaja (suma svih narudžbi)
            var totalSales = orders.Sum(o => o.TotalPrice);
            Console.WriteLine($"Ukupna prodaja: {totalSales} EUR");

            // 3. Narudžbe sortirane po datumu (najnovije prvo)
            var ordersByDate = orders.OrderByDescending(o => o.OrderDate);
            Console.WriteLine("Narudžbe sortirane po datumu:");
            foreach (var order in ordersByDate)
            {
                Console.WriteLine($"Narudžba ID: {order.Id}, Datum: {order.OrderDate.ToShortDateString()}");
            }

            // 4. Buketi koji sadrže ruže
            var bouquetsWithRoses = new List<Bouquet> { bouquet1, bouquet2, bouquet3 }.Where(b => b.Flowers.Any(f => f.Type == FlowerType.Rose));
            Console.WriteLine("Buketi s ružama:");
            foreach (var bouquet in bouquetsWithRoses)
            {
                Console.WriteLine($"Buket: {bouquet.Name}");
            }

            // 5. Kupci s više od 100 loyalty bodova
            var loyalCustomers = new List<Customer> { customer1, customer2, customer3 }.Where(c => c.LoyaltyPoints > 100);
            Console.WriteLine("Lojalni kupci (preko 100 bodova):");
            foreach (var customer in loyalCustomers)
            {
                Console.WriteLine($"{customer.Name} {customer.Surname}: {customer.LoyaltyPoints} bodova");
            }

            // 6. Dostave koje su već obavljene
            var completedDeliveries = new List<Delivery> { delivery1, delivery2, delivery3 }.Where(d => d.Status == "Dostavljeno");
            Console.WriteLine("Obavljene dostave:");
            foreach (var delivery in completedDeliveries)
            {
                Console.WriteLine($"Dostava ID: {delivery.Id}, Datum: {delivery.DeliveryDate.ToShortDateString()}");
            }
        }
    }
}
