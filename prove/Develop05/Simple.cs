class Simple : Goal
{
    public int Points;

    public Simple(string description, int points = 100)
        : base(description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {
        Completed = true;
    }
}