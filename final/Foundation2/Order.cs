using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> Products { get; set; }
        private Customer Customer { get; set; }

        public Order(List<Product> products, Customer customer)
        {
            Products = products;
            Customer = customer;
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (var product in Products)
            {
                totalCost += product.GetTotalCost();
            }

            double shippingCost = Customer.LivesInUSA() ? 5.0 : 35.0;
            return totalCost + shippingCost;
        }

        public string GetPackingLabel()
        {
            string label = "Packing Label:\n";
            foreach (var product in Products)
            {
                label += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label:\n{Customer.Name}\n{Customer.GetAddress().GetFormattedAddress()}";
        }
    }
}
