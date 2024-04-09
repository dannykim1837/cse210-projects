using System;

public class CyclingActivity : Activity
{
    public CyclingActivity(DateTime date, int minutes, float distance) : base(date, minutes, distance)
    {
        
    }

    public override float GetPace()
    {
        return Distance / Minutes * 60;
    }
}