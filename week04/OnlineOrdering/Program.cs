using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address addr1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Address addr2 = new Address("No. 244 Justice Bode Vivour Cresc", "Abuja", "FCT", "Nigeria");

        // Create customers
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("David Smith", addr2);

        // Create orders
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "P001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25, 2));

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Phone", "P003", 800, 1));
        order2.AddProduct(new Product("Charger", "P004", 20, 3));

        // Order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
}