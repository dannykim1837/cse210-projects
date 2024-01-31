using System;
using System.Collections.Generic;
using System.IO;

namespace Learning02
{
    class Program
    {
        static Journal journal = new Journal();

        static void Main(string[] args)
        {
            bool keepGoing = true;
            Console.Clear();
            while (keepGoing)
            {
                ShowMenu();
                int selection = int.Parse(Console.ReadLine());

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
                    SaveToFile();
                }
                else if (selection == 4)
                {
                    LoadFromFile();
                }
                else if (selection == 5)
                {
                    keepGoing = false;
                    Console.WriteLine("Goodbye!");
                }
            }
        }

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

        static void DisplayJournal()
        {
            Console.WriteLine("Journal Entries:\n");

            foreach (var entry in journal.Entries)
            {
                Console.WriteLine($"Date: {entry.Date}, Prompt: {entry.Prompt}, Response: {entry.Response}");
            }
        }

        static void SaveToFile()
        {
            Console.Write("Enter filename to save: ");
            var fileName = Console.ReadLine();

            try
            {
                FileSystem.SaveToFile(fileName, journal);
                Console.WriteLine("Journal saved successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving journal: {ex.Message}");
            }
        }

        static void LoadFromFile()
        {
            Console.Write("Enter filename to load: ");
            var fileName = Console.ReadLine();

            try
            {
                Journal loadedJournal = FileSystem.LoadFromFile(fileName);
                journal = loadedJournal;
                Console.WriteLine("Journal loaded successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("Select Option \n 1. Write \n 2. Display \n 3. Save \n 4. Load  \n 5. Quit");
        }

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