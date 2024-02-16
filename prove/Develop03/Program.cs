using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);
        string selection = "";

        Console.Clear();
        Console.WriteLine(scripture.GetVisibleScripture());

        while (true)
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish");
            selection = Console.ReadLine();

            if (selection == "quit")
                break;

            Console.Clear();
            if (!scripture.HideRandomWord())
            {
                scripture.MoveToNextSentence();
                if (!scripture.HasNextSentence())
                {
                    Console.WriteLine("All sentences are studied. Press any key to exit.");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine(scripture.GetVisibleScripture());
        }

        Console.WriteLine("Study session ended. Press any key to exit.");
        Console.ReadKey();
    }
}
