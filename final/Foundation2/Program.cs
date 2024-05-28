using System;

// Program class to demonstrate the functionality
public class Program
{
    public static void Main()
    {
        // Create addresses
        var address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        var address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        // Create customers
        var customer1 = new Customer("Willie Inah", address1);
        var customer2 = new Customer("Jesam Smith", address2);

        // Create products
        var product1 = new Product("Laptop", "A123", 999.99, 1);
        var product2 = new Product("Mouse", "B456", 25.50, 2);
        var product3 = new Product("Keyboard", "C789", 75.75, 1);
        var product4 = new Product("Monitor", "D012", 199.99, 1);

        // Create orders and add products to them
        var order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        var order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Store orders in a list
        var orders = new List<Order> { order1, order2 };

        // Display information for each order
        foreach (var order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order.GetTotalCost():0.00}\n");
        }
    }
}