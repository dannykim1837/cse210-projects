using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        
        RunningActivity runningActivity = new RunningActivity(new DateTime(2024, 4, 8), 30, 3.0f);
        CyclingActivity cyclingActivity = new CyclingActivity(new DateTime(2024, 4, 8), 20, 6.0f);
        SwimmingActivity swimmingActivity = new SwimmingActivity(new DateTime(2024, 4, 8), 60, 20);
        Console.Clear();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}