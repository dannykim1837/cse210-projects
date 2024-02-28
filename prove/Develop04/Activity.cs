class Activity
{
    public string activity;
    public string description;

    public void start()
    {
        System.Console.WriteLine($"Welcome to the {activity} Activity!!");
        System.Console.WriteLine(description);

    }

    public void finish()
    {
        System.Console.WriteLine("");
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