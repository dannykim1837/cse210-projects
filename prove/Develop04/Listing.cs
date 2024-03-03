class Listing : Activity
{

    public Listing() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") { }

    int sentenceCount = 0;

    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };


    public void Animation()
    {
        Random random = new Random();
        DateTime startTime = DateTime.Now;
        string prompt = prompts[random.Next(prompts.Length)];
        Console.Clear();
        System.Console.WriteLine("List as many responses you can to the following prompt");
        System.Console.WriteLine($"\n---- {prompt} ---- \n");
        System.Console.WriteLine("You may begin :");
        count();
        
        while (DateTime.Now < startTime.AddSeconds(Duration))
        {
            string input = System.Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                sentenceCount++;
                System.Console.WriteLine($"> {input}");
            }
        }
        
        System.Console.WriteLine(($"You have made {sentenceCount} sentences in total."));

    }

    
}