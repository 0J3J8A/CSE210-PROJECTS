using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.WriteLine("Hello World! This is the Journal Project.");
        while (true)
        {
            int choice = DisplayMenu(); // Calling the MAIN MENU

            if (choice == 1)
            { WriteEntry(journal); }
            else if (choice == 2)
            { DisplayThoughts(journal); }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

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

        // Create a new Entry to save the prompt and response in the List
        Entry newEntry = new Entry(randomPrompt, userInput);
        journal.AddEntry(newEntry);
    }

    static void DisplayThoughts(Journal journal)
    {
        journal.DisplayEntries();
    }

}