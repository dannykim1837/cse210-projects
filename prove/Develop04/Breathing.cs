class Breathing : Activity
{
    public Breathing() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.") { }

    public void Animation()
    {
        DateTime startTime = DateTime.Now;

        while (DateTime.Now < startTime.AddSeconds(Duration))
        {
        System.Console.WriteLine("Let's begin the breathing exercise...");
        for (int i = 0; i < Duration; i += 2)
        {
            System.Console.WriteLine("Breathe in...");
            Thread.Sleep(2000); 
            System.Console.WriteLine("Breathe out...");
            Thread.Sleep(2000); 
            System.Console.WriteLine("Breathing complete!");
        }
        }
    }
}