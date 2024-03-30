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


        
    }
}