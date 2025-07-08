using System.IO;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Hello World! This is the Journal Project.");
        while (true) //Shows creativity and exceeds core requirements (I CREATE A LOOP TO USE THE MAIN MENU)
        {
            int choice = DisplayMenu(); // CALLING THE MAIN MENU

            if (choice == 1)
            { WriteEntry(journal); }
            else if (choice == 2)
            { DisplayThoughts(journal); }
            else if (choice == 3)
            {
                Console.WriteLine("Enter the filename to load your journal:");
                string filename = Console.ReadLine();

                journal.LoadFromFile(filename);
                DisplayThoughts(journal);      // SHOWS THE ENTRIES AFTER LOAD THE FILE GIVEN BY THE USER
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter the filename to save your journal:");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                //THE CLASS IS GOING TO CREATE A NEW FILE WITH THE NAME THAT WOULD BE GIVEN BY THE USER
            }
            else if (choice == 5)
            {
                Console.WriteLine("Goodbye!");
                break; // FINISH THE PROGRAM
            }
            else
            {
                Console.WriteLine("Invalid option, try again.");
                // RETURN TO THE MAIN MENU
            }
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine("This is the Journal Main Menu, please select an option: ");
        Console.WriteLine("1.Write");
        Console.WriteLine("2.Display");
        Console.WriteLine("3.Load");
        Console.WriteLine("4.Save");
        Console.WriteLine("5.Quit");
        Console.WriteLine("What would you like to do? ");
        string ANSWER1 = Console.ReadLine();
        int ANSWER_1 = int.Parse(ANSWER1);
        return ANSWER_1;
    }

    static void WriteEntry(Journal journal)
    {
        PromptGenerator _prompt = new PromptGenerator();
        string randomPrompt = _prompt.GetRandomPrompt();
        Console.WriteLine($"Please thing in this: {randomPrompt}");
        Console.WriteLine($"Please type your response: ");
        string userInput = Console.ReadLine();

        // CREATE A NEW ENTRY TO SAVE THE PROMPT ANS RESPONSE
        Entry newEntry = new Entry(randomPrompt, userInput);
        journal.AddEntry(newEntry);
    }

    static void DisplayThoughts(Journal journal)
    {
        journal.DisplayEntries();
    }
}

//Shows creativity and exceeds core requirements 

// (I CREATE A LOOP TO USE THE MAIN MENU) LINE 11

// (I ADD A MESSAGE IN THE LINES 36 AND 52 OF Journal.cs / TO EXPLAIN THAT THE ACTION WAS COMPLETED SUCCESFULLY)