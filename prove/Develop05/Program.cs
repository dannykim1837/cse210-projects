class Program
{
    static SaveLoad saveLoad = new SaveLoad();
    static List<Goal> goals = new List<Goal>();
    static List list = new List();

    static void Main(string[] args)
    {
        bool keepGoing = true;

        Console.Clear();

        while (keepGoing)
        {
            int selection = Menu();
            Console.Clear();

            if (selection == 1)
            {
                list.CreateGoal();
            }
            else if (selection == 2)
            {
                list.ListGoals();
            }
            else if (selection == 3)
            {
                saveLoad.Save(goals);
            }
            else if (selection == 4)
            {
                goals = saveLoad.Load();
            }
            else if (selection == 5)
            {
                list.RecordEvent();
            }
            else if (selection == 6)
            {
                keepGoing = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
    
    public static int Menu()
        {
            System.Console.WriteLine("Menu Options \n 1. Create New Goals \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6. Quit");
            System.Console.Write("\nSelect a choice from the menu: ");
            var selection = int.Parse(Console.ReadLine());
            return selection;
        }

    
}