class SaveLoad
{
    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void WriteFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }

    public void Save(List<Goal> goals)
    {
        List<string> lines = new List<string>();
        foreach (var goal in goals)
        {
            lines.Add($"{goal.GoalTitle},{goal.GoalDescription},{goal.GoalPoint},{goal.Completed}");
        }
        WriteFile(lines.ToArray());
        Console.WriteLine("Goals saved.");
    }

    public List<Goal> Load()
    {
        List<Goal> loadedGoals = new List<Goal>();
        var lines = ReadFile();
        foreach (var line in lines)
        {
            var parts = line.Split(',');
            string goalTitle = parts[0];
            string goalDescription = parts[1];
            int goalPoint = int.Parse(parts[2]);
            bool completed = bool.Parse(parts[3]);
            Goal goal = new Goal(goalTitle, goalDescription, goalPoint);
            goal.Completed = completed;
            loadedGoals.Add(goal);
        }
        Console.WriteLine("Goals loaded.");
        return loadedGoals;
    }
}
