class Goal
{
    public string GoalTitle;
    public string GoalDescription;
    public int GoalPoint;
    public bool Completed;

    public Goal(string goalTitle, string goalDescription, int goalPoint, bool completed = false)
    {
        GoalTitle = goalTitle;
        GoalDescription = goalDescription;
        GoalPoint = goalPoint;
        Completed = completed;
    }

    public virtual void RecordEvent()
    {
        Completed = true;
    }

    public override string ToString()
    {
        return $"{(Completed ? "[X]" : "[ ]")} {GoalTitle} - {GoalDescription} ({GoalPoint} points)";
    }
}