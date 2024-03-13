class List
{   
    int Bonus;
    int goalPoint;
    int goalTimes = 0;
    string goalTitle;
    string goalDescription;

    private List<Goal> goals = new List<Goal>();

    public void CreateGoal()
    {
        System.Console.WriteLine("Select goal type:");
        System.Console.WriteLine("1. Simple Goal");
        System.Console.WriteLine("2. Eternal Goal");
        System.Console.WriteLine("3. Checklist Goal");
        System.Console.WriteLine("Which type of goal would you like to create?");
        int goalType = int.Parse(Console.ReadLine());


        if (goalType == 1)
        {
            System.Console.WriteLine("What is the name of your goal?");
            goalTitle = Console.ReadLine();
            System.Console.Write("What is a short description of it?: ");
            goalDescription = Console.ReadLine();
            System.Console.WriteLine("What is the amount of points associated with this goal?");
            goalPoint = int.Parse(Console.ReadLine());

            Simple simple = new Simple(goalTitle,goalDescription,goalPoint,false);
            goals.Add(simple);  
            return;
        }
        else if (goalType == 2)
        {
            System.Console.WriteLine("What is the name of your goal?");
            goalTitle = Console.ReadLine();
            System.Console.Write("What is a short description of it?: ");
            goalDescription = Console.ReadLine();
            System.Console.WriteLine("What is the amount of points associated with this goal?");
            goalPoint = int.Parse(Console.ReadLine());

            Eternal eternal = new Eternal(goalTitle,goalDescription,goalPoint);
            goals.Add(eternal);
            return;
        }
        else if (goalType == 3)
        {
            System.Console.WriteLine("What is the name of your goal?");
            goalTitle = Console.ReadLine();
            System.Console.Write("What is a short description of it?: ");
            goalDescription = Console.ReadLine();
            System.Console.WriteLine("What is the amount of points associated with this goal?");
            goalPoint = int.Parse(Console.ReadLine());

            System.Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            goalTimes = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine(" What is the bonus for accomplishiing it that many times? ");
            Bonus = int.Parse(Console.ReadLine());
            Checklist checklist = new Checklist(goalTitle, goalDescription,goalPoint, 0, goalTimes, Bonus);
            goals.Add(checklist);
        }
        else
        {
            System.Console.WriteLine("Invalid goal type.");
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in goals)
        {
            System.Console.WriteLine(goal.ToString());
        }
    }

    public void RecordEvent()
    {
        System.Console.WriteLine("Select goal to record event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            System.Console.WriteLine($"{i + 1}. {goals[i].Description}");
        }
        int selection = int.Parse(Console.ReadLine()) - 1;
        if (selection >= 0 && selection < goals.Count)
        {
            goals[selection].RecordEvent();
            System.Console.WriteLine("Event recorded.");
        }
        else
        {
            System.Console.WriteLine("Invalid selection.");
        }
    }
}