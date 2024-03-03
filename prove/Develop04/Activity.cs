class Activity : Program
{
    public string Name;
    public string Description;
    public int Duration;

    Program program = new Program();

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
        Console.Clear();
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
        Menu();
    }

    public void Animation()
    {
        for(int i= 0; i <3; i++)
        {
            System.Console.Write("\\");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("|");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("/");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("-");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
        }
    }

    public void ani()
    {
        for(int i= 0; i <3; i++)
        {
            System.Console.Write("\\");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("|");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("/");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
            System.Console.Write("-");
            Thread.Sleep(500);
            System.Console.Write("\b\b\b\b"); 
        }
    }
    public void count()
{
    for (int i = 5; i > 0; i--)
    {
        System.Console.Write(i);
        Thread.Sleep(1000);
        System.Console.Write("\b"); 
        System.Console.Write("    "); 
        System.Console.Write("\b\b\b\b"); 
    }
}
}