using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");

        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        int square = number * number;

        Console.WriteLine($"{name}, the square of your number is {square}");

    }
}