using System;
using System.Collections.Generic;

class Program {
    static void Main(string[] args) {
        Product book = new Product("Harry Potter and the Philosopher's Stone", 123, 10.99m, 1);
        Product shirt = new Product("T-Shirt", 456, 19.99m, 2);

        Address address1 = new Address("123 Main St.", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(new List<Product> { book, shirt }, customer1);

        Address address2 = new Address("456 Market St.", "London", "", "United Kingdom");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(new List<Product> { shirt }, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label:\n{order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order1.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order1.TotalPrice()}");

        Console.WriteLine("Order 2:");
        Console.WriteLine($"Packing Label:\n{order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label:\n{order2.GetShippingLabel()}");
        Console.WriteLine($"Total Cost: {order2.TotalPrice()}");
    }
}
