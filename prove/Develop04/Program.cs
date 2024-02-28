using System;

class Program
{
    static void Main(string[] args)
    {
        bool kg = ture;
        int selection = Menu();
        while(kg)
        {
            if(selection == 1)
                {
                    breathing.start();
                    breathing.finish();
                }
            else if (selection == 2)
                {
                    reflecting.start();
                    reflecting.finish();
                }
            else if (selection == 3)
                {
                    listing.start();
                    listing.finish();
                }
            else if (selection == 4)
                {
                    kg = false;
                    Console.WriteLine("Goodbye!");
                }
        }
    }

    static int Menu()
        {
            Console.WriteLine("Menu Options \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            var selection = int.Parse(Console.ReadLine());
            return selection;
        }
}