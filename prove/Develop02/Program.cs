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

            while (keepGoing)
            {
                int selection = ShowMenu();

                if (selection == 1)
                {
                    Console.Clear();
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
        
        // entry
        static void WriteEntry()
        {
            Entry entry = new Entry();
            Console.WriteLine("Random Prompt: " + entry.GetRandomPrompt());
            Console.Write("Your Response: ");
            var response = Console.ReadLine();
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
        static int ShowMenu()
        {
            Console.WriteLine("Select Option \n 1. Write \n 2. Display \n 3. Save \n 4. Load  \n 5. Quit");
            Console.Write("\nEnter your choice: ");
            var selection = int.Parse(Console.ReadLine());
            return selection;
        }

        // random prompt list
        
    }
}

