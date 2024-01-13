using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your score? ");
        string userInput = Console.ReadLine();
        int score = int.Parse(userInput);

        string letter = "";

        if (score >= 90)
        {    
            letter = "A";
        }
        else if (score >=80)
        {    
            letter = "B";
        }
        else if (score >=70)
        {    
            letter = "C";
        }
        else if (score >=60)
        {    
            letter = "D";
        }
        else 
        {    
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is: {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Congratulation. You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }

    }
}