class Eternal : Goal
{
    public int Points;

    public Eternal(string description, int points = 100)
        : base(description)
    {
        Points = points;
    }

    public override void RecordEvent()
    {

    }
}