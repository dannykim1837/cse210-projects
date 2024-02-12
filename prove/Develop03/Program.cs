using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Word word = new Word();
        string selection = "";
        while(selection != "quit") 
        {
            
            System.Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            selection = Console.ReadLine();

            if(selection == "quit") 
            {
                System.Console.WriteLine("Finish");
            }
            else
            {
                System.Console.WriteLine(scripture.GetScripture());
                word.HideRandomWords(selection);
                System.Console.WriteLine("Continuning");
            }
        }
    }
}