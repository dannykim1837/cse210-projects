using System;

class Program
{
    
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing();
        Reflecting reflecting= new Reflecting();
        Listing listing= new Listing();
        bool keepGoing = true;

        Console.Clear();
        int selection = Menu();
        
        while (keepGoing)
        {
            if(selection == 1)
                {
                    Console.Clear();
                    breathing.start();
                    breathing.Animation();
                    breathing.finish();

                }
            else if (selection == 2)
                {
                    Console.Clear();
                    reflecting.start();
                    reflecting.Animation();
                    reflecting.finish();
                }
            else if (selection == 3)
                {
                    Console.Clear();
                    listing.start();
                    listing.Animation();
                    listing.finish();
                }
            else if (selection == 4)
                {
                    Console.Clear();
                    keepGoing = false;
                    Console.WriteLine("Goodbye!");
                }
        }
    }

    public static int Menu()
        {
            Console.WriteLine("Menu Options \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            var selection = int.Parse(Console.ReadLine());
            return selection;
        }
}