using System;
using System.Collections.Generic;

class SaveLoad
{
    private List<Goal> goals = new List<Goal>();

    public void AddEntry(Goal goal)
    {
        goals.Add(goal);
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
        goals.AddRange(loadedGoals);
        Console.WriteLine("Goals loaded.");
        return loadedGoals;
    }

    
    
    static string[] ReadFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    

}
