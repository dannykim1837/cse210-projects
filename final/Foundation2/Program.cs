using System;

class Program
{
    static void Main(string[] args)
    {
        Address address0 = new Address("291 E 7th S", "Rexburg", "ID", "USA");
        Customer customer0 = new Customer("Danny Kim", address0);
        List<Product> products0 = new List<Product>()
        {
            new Product("Steak", "S001", 29.87, 1),
            new Product("Pepsi", "P001", 2.99, 1)
        };
        Order order0 = new Order(products0, customer0);

        Address address1 = new Address("2495 E Lincoln Rd", "Idaho Falls", "ID", "USA");
        Customer customer1 = new Customer("Daehwan Kim", address1);
        List<Product> products1 = new List<Product>()
        {
            new Product("Rice", "R001", 15.98, 1),
            new Product("Choco mont", "C001", 7.99, 1),
            new Product("Bake", "B001", 3.99, 1)
        };
        Order order1 = new Order(products1, customer1);

        Console.Clear();
        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine("Shipping Address :");
        System.Console.WriteLine(order0.s_label());
        System.Console.WriteLine("Menu :");
        System.Console.WriteLine(order0.p_label());
        System.Console.WriteLine($"Total : {order0.total():C}");
        System.Console.WriteLine("-----------------------------------------");
        System.Console.WriteLine("Shipping Address :");
        System.Console.WriteLine(order1.s_label());  
        System.Console.WriteLine("Menu :");
        System.Console.WriteLine(order1.p_label());
        System.Console.WriteLine($"Total : {order1.total():C}");
        System.Console.WriteLine("-----------------------------------------");
    }
}