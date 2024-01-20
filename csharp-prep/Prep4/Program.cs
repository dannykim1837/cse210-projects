using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
    
    List<int> myInts = new List<int>();
    var otherInts = new List<int>();

    int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            if (userNumber != 0)
            {
                myInts.Add(userNumber);
            }
        }
        //sum
        int sum = 0;
        foreach (int number in myInts)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");
        
        //average
        double average = myInts.Count > 0 ? myInts.Average() : 0;
        
        Console.WriteLine($"The average is: {average}");

        //largest
        int largest = myInts[0];
        foreach (int number in myInts)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        Console.WriteLine($"The largest number is: {largest}");


    }
}