using System;
using System.Collections.Generic;

namespace Learning02
{
    class Program
    {
        static Journal journal = new Journal();

        // main
        static void Main(string[] args)
        {
            bool keepGoing = true;
            // 
            Console.Clear();
            while (keepGoing)
            {
                ShowMenu();
                int selection;
                if (int.TryParse(Console.ReadLine(), out selection))
                {
                    if (selection == 1)
                    {
                        WriteEntry();
                    }
                    else if (selection == 2)
                    {
                        DisplayJournal();
                    }
                    else if (selection == 3)
                    {
                        var lines = journal.Export();
                        WriteFile(lines);
                    }
                    else if (selection == 4)
                    {
                        var lines = ReadFile();
                        journal = new Journal(lines);
                    }
                    else if (selection == 5)
                    {
                        keepGoing = false;
                        Console.WriteLine("Goodbye!");
                    }
                }
            }    
        }
        
        // entry
        static void WriteEntry()
        {
            Console.WriteLine("Random Prompt: " + GetRandomPrompt());
            Console.Write("Your Response: ");
            var response = Console.ReadLine();

            var entry = new Entry
            {
                Prompt = GetRandomPrompt(),
                Response = response,
                Date = DateTime.Now
            };

            journal.AddEntry(entry);
            Console.WriteLine("Entry added successfully!");
        }

        // journal
        static void DisplayJournal()
        {
            Console.WriteLine("Journal Entries:\n");

            foreach (var entry in journal.Entries)
            {
                Console.WriteLine($"Prompt: {entry.Prompt}, \nResponse: {entry.Response}, \nDate: {entry.Date}");
            }
        }

        // save file
        static string[] ReadFile()
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            return System.IO.File.ReadAllLines(filename);
        }

        // load file
        static void WriteFile(string[] lines)
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            System.IO.File.WriteAllLines(filename, lines);
        }
        
        
        // menu
        static void ShowMenu()
        {
            Console.WriteLine("Select Option \n 1. Write \n 2. Display \n 3. Save \n 4. Load  \n 5. Quit");
        }

        // random prompt list
        static string GetRandomPrompt()
        {
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}

