class List
{
    private List<Goal> goals = new List<Goal>();

    public void CreateGoal()
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        int goalType = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the name of your goal?");
        string goalTitle = Console.ReadLine();
        Console.WriteLine("What is a short description of it?: ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int goalPoint = int.Parse(Console.ReadLine());

        if (goalType == 1)
        {
            goals.Add(new Simple(goalTitle, goalDescription, goalPoint));
        }
        else if (goalType == 2)
        {
            goals.Add(new Eternal(goalTitle, goalDescription, goalPoint));
        }
        else if (goalType == 3)
        {
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int goalTimes = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            goals.Add(new Checklist(goalTitle, goalDescription, goalPoint, goalTimes, bonus));
        }
        else
        {
            Console.WriteLine("Invalid goal type.");
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
        Console.WriteLine("Select goal to record event for:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GoalTitle}");
        }
        int selection = int.Parse(Console.ReadLine()) - 1;
        if (selection >= 0 && selection < goals.Count)
        {
            goals[selection].RecordEvent();
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }
    public void Save(List<Goal> goalsToSave)
    {
        List<string> lines = new List<string>();

        foreach (var goal in goalsToSave)
        {
            string completed = goal.Completed ? "true" : "false";
            string goalEntry = $"{goal.GoalTitle},{goal.GoalDescription},{goal.GoalPoint},{completed}";
            lines.Add(goalEntry);
        }

        WriteFile(lines.ToArray());
    }
    
    public void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
        Console.WriteLine("Goals saved to file.");
    }
}