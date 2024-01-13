using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        var first = Console.ReadLine();
        Console.Write("What is your last name? ");
        var last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}