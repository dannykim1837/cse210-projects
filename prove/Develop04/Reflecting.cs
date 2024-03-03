class Reflecting : Activity
{
    public Reflecting() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.") { }

    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Animation()
    {
        Random random = new Random();
        DateTime startTime = DateTime.Now;

        string prompt = prompts[random.Next(prompts.Length)];
        Console.Clear();
        System.Console.WriteLine("Considering the following prompt");
        System.Console.WriteLine($"---- {prompt} ---- \n");
        System.Console.WriteLine("\nWhen you have something in mind, press enter to continue");
        System.Console.WriteLine("Now, ponder on each of the following question as they related to this experience.");
        System.Console.WriteLine("You may begin :");
        count();
        Console.Clear();

        while (DateTime.Now < startTime.AddSeconds(Duration))
        {
            string question = questions[random.Next(questions.Length)];
            System.Console.WriteLine($"> {question}");
            ani();
        }
    }
}