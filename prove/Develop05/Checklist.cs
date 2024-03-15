class Checklist : Goal
{
    public int GoalTimes { get; set; }
    public int Bonus { get; set; }

    public Checklist(string goalTitle, string goalDescription, int goalPoint, int goalTimes, int bonus)
        : base(goalTitle, goalDescription, goalPoint)
    {
        GoalTimes = goalTimes;
        Bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (++GoalTimes >= GoalTimes)
        {
            GoalPoint += Bonus;
            Completed = true;
        }
    }
}