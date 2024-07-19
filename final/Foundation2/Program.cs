using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create some addresses
            Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
            Address address2 = new Address("456 Oak St", "Shelbyville", "IL", "USA");

            // Create some customers
            Customer customer1 = new Customer("John Doe", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create some products
            Product product1 = new Product("Laptop", 1, 999.99, 1);
            Product product2 = new Product("Mouse", 2, 25.50, 2);
            Product product3 = new Product("Keyboard", 3, 75.00, 1);

            // Create orders
            Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
            Order order2 = new Order(new List<Product> { product2, product3 }, customer2);

            // Display order information
            DisplayOrderDetails(order1);
            DisplayOrderDetails(order2);
        }

        static void DisplayOrderDetails(Order order)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");
            Console.WriteLine();
        }
    }
}
