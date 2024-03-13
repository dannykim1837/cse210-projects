class Goal
{
    public string Description;
    public bool Completed;

    public Goal(string description)
    {
        Description = description;
        Completed = false;
    }

    public virtual void RecordEvent() { }

    public override string ToString()
    {
        return $"{(Completed ? "[X]" : "[ ]")} {Description}";
    }
}