class Activity
{
    public string activityName;
    public string description;
    public int Duration;

    public Activity(string name, string description)
    {
        activityName = name;
        Description = description;
    }

    public void start()
    {
        System.Console.WriteLine($"Welcome to the {name} - {description}");
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        Duration = int.Parse(Console.ReadLine());
        System.Console.WriteLine("get ready...");
        animation();
    }

    public void finish()
    {
        System.Console.WriteLine("Well done!!");
        animation();
        System.Console.WriteLine($"You have completed another {duration} seconds of the {name}");
        animation();
        Console.Clear();
    }

    public animation()
    {
        for(int i= 0; i <3; i++)
        {
            System.Console.Write("--");
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
            System.Console.Write("\\");
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
            System.Console.Write("||");
            Thread.Sleep(1000);
            System.Console.Write("\b \b");
            System.Console.Write("//");
            Thread.Sleep(1000);
        }
    }
}