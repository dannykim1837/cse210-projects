namespace Learning02;
using System;
using System.IO; 


class Program
{   
    static void Main(string[] args)
    {
        var journal = new Journal();
        
        Console.Clear();

        while (keepGoing) {
            var selection = ShowMenu();

            if (selection == 1) {
                Entry();
            }
            else if (selection == 2) {
                Journal();
            }
            else if (selection == 3) {
                SaveToFile
            }
            else if (selection == 4) {

            }
            else if (selection == 5) {
                keepGoing = false;
            }

            
        }
    }
}

    static int ShowMenu() {
        System.Console.WriteLine("Select Option \n 1. Write \n 2. Display \n 3. Load \n 4. Save  \n 5. Quit");
        string input = Console.ReadLine();
        return int.Parse(input);
    }

    public void SaveToFile() {

    }

    public void LoadFromFile() {

    }
