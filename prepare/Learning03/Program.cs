using System;

class Program
{
    static void Main(string[] args)
    {
        Fractoin fraction1 = new Fractoin();
        System.Console.WriteLine(fraction1.GetFractionString());
        System.Console.WriteLine(fraction1.GetDecimalValue());

        Fractoin fraction2 = new Fractoin(5);
        System.Console.WriteLine(fraction2.GetFractionString());
        System.Console.WriteLine(fraction2.GetDecimalValue());

        Fractoin fraction3 = new Fractoin(3, 4);
        System.Console.WriteLine(fraction3.GetFractionString());
        System.Console.WriteLine(fraction3.GetDecimalValue());

        Fractoin fraction4 = new Fractoin(1, 3);
        System.Console.WriteLine(fraction4.GetFractionString());
        System.Console.WriteLine(fraction4.GetDecimalValue());
    }
}