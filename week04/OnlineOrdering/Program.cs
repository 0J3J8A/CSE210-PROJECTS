using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "10001", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "M5V3L9", "Canada");
        Address address3 = new Address("789 Hills Ville", "Phoenix", "AR", "10002", "USA");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Emma Johnson", address2);
        Customer customer3 = new Customer("Peter Parker", address3);

        // Create products
        Product product1 = new Product("Laptop", "P100", 999.99, 1);
        Product product2 = new Product("Mouse", "P101", 19.99, 2);
        Product product3 = new Product("Keyboard", "P102", 49.99, 1);
        Product product4 = new Product("Monitor", "P103", 199.99, 2);

        // Create first order
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create second order
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);

        // Create second order
        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product3);
        order3.AddProduct(product1);
        order3.AddProduct(product4);

        // Display order information
        DisplayOrderDetails(order1);
        DisplayOrderDetails(order2);
        DisplayOrderDetails(order3);
    }

    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine("====================================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():0.00}");
        Console.WriteLine("====================================\n");
    }
}