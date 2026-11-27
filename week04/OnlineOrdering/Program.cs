using System;

class Program
{
    static void Main(string[] args)
    {
        Customer c1 = new Customer("John Smith", new Address("123 Main St", "Rexburg", "ID", "USA"));
        Order o1 = new Order(c1);
        o1.AddProduct(new Product("Laptop Stand", "LS100", 25.50, 2));
        o1.AddProduct(new Product("USB Cable", "UC200", 4.99, 3));
        Customer c2 = new Customer("Marie Dupont", new Address("45 Rue des Fleurs", "Pointe-Noire", "Kouilou", "Congo"));
        Order o2 = new Order(c2);
        o2.AddProduct(new Product("Keyboard", "KB300", 39.99, 1));
        o2.AddProduct(new Product("Mouse", "MS400", 15.00, 2));
        o2.AddProduct(new Product("Webcam", "WC500", 49.90, 1));
         foreach (Order order in new[] { o1, o2 })
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total price: ${order.GetTotalPrice():F2}\n");
            Console.WriteLine("----------------------------\n");
        }

    }
}