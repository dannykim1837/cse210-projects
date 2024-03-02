class Activity
{
    public string Name;
    public string Description;
    public int Duration;

    public Activity(string name, string description)
    {
        Name = name;
        Description = description;
    }

    public void start()
    {
        System.Console.WriteLine($"Welcome to the {Name} - {Description}");
        System.Console.WriteLine("How long, in seconds, would you like for your session?");
        Duration = int.Parse(Console.ReadLine());
        System.Console.WriteLine("get ready...");
        Animation();
        Thread.Sleep(3000);
    }

    public void finish()
    {
        System.Console.WriteLine("Well done!!");
        Animation();
        System.Console.WriteLine($"You have completed another {Duration} seconds of the {Name}");
        Animation();
        Console.Clear();
    }

    public void Animation()
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