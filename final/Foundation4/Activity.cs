using System;

public class Activity
{
    private DateTime Date;
    protected int Minutes;
    protected float Distance;
    

    public Activity(DateTime date, int minutes, float distance)
    {
        this.Date = date;
        this.Minutes = minutes;
        this.Distance = distance;
    }

    public virtual float GetDistance()
    {
        return Distance;
    }

    public virtual float GetSpeed()
    {
       return GetDistance() / Minutes * 60;
    }

    public virtual float GetPace()
    {
       return  Minutes / GetDistance();
    }

    public string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")}\n{GetType().Name} \n({Minutes} min) - Distance: {GetDistance()} km, Speed: {GetSpeed()} km/h, Pace: {GetPace()} min/km";
    }

}