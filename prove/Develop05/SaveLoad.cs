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
            lines.Add(goal.Description + "," + goal.Completed);
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
            string description = parts[0];
            bool completed = bool.Parse(parts[1]);
            Goal goal = new Goal(description);
            goal.Completed = completed;
            loadedGoals.Add(goal);
        }
        Console.WriteLine("Goals loaded.");
        return loadedGoals;
    }
}