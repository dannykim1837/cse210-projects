using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    
        // Ask for random number
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1, 101);
        int guess;
        do{
        // Ask for user guess
        System.Console.Write("Guess a number : ");
        guess = int.Parse(Console.ReadLine());
        // Check
        if(guess < 1 || guess > 101){
            break;
        }
        if (guess > random) {
            System.Console.WriteLine("Too High");
        }
        else if (guess < random)
        {
            System.Console.WriteLine("Too Low");
        }
        else
        {
            System.Console.WriteLine("Correct");
        }
    } while(random != guess);


}
}


        
