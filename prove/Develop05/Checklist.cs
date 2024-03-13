class Checklist : Goal
{
    public int TargetCount;
    public int CompletedCount;

    public Checklist(string description, int targetCount)
        : base(description)
    {
        TargetCount = targetCount;
        CompletedCount = 0;
    }

    public override void RecordEvent()
    {
        CompletedCount++;
        if (CompletedCount >= TargetCount)
        {
            Completed = true;
        }
        else
        {
        }
    }

    public override string ToString()
    {
        return $"{(Completed ? "[X]" : "[ ]")} {Description} (Completed {CompletedCount}/{TargetCount} times)";
    }
}