using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference();
        Scripture scripture = new Scripture(reference);;
        string selection = "";

        while(selection != "quit") 
        {
            System.Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            selection = Console.ReadLine();

            if(selection != "quit") 
            {
                Console.Clear();
                System.Console.WriteLine(scripture.GetScripture());
                scripture.HideRandomWord();
                System.Console.WriteLine("Continuning");
            }
            System.Console.WriteLine("Finish");
        }
    }
}