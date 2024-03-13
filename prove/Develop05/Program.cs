using System;

class Program
{
    
    static void Main(string[] args)
    {
        List list = new List();
        SaveLoad saveload = new SaveLoad();
        bool keepGoing = true;

        Console.Clear();
        int selection = Menu();
        
        while (keepGoing)
        {
            if(selection == 1)
                {
                    Console.Clear();
                    

                }
            else if (selection == 2)
                {
                    Console.Clear();
                    
                }
            else if (selection == 3)
                {
                    Console.Clear();
                    
                }
            else if (selection == 4)
                {
                    Console.Clear();
                    keepGoing = false;
                    Console.WriteLine("Goodbye!");
                }
            selection = Menu();
        }
    }

    public static int Menu()
        {
            System.Console.WriteLine($"Points: {list.Pointnumber()}");
            System.Console.WriteLine("Menu Options \n 1. Create New Goals \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            System.Console.Write("\nSelect a choice from the menu: ");
            var selection = int.Parse(Console.ReadLine());
            return selection;
        }
}