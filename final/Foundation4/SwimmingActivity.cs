using System;

public class SwimmingActivity : Activity
{
    public SwimmingActivity(DateTime date, int minutes, float distance) : base(date, minutes, distance)
    {
        
    }

    public override float GetDistance()
    {
        return Distance * 50 / 1000;
    }
}