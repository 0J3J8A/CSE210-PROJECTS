using System;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        int choice;
        do
        {
            choice = DisplayMenu();

            if (choice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
            }
            else if (choice == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
            }
            else if (choice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
            }
            else if (choice == 4)
            {
                BodyScanActivity bodyScanActivity = new BodyScanActivity();
                bodyScanActivity.Run();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(2000);
            }

        } while (choice != 5);
    }

    static int DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("Mindfulness Activities Menu:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Body Scan Activity");
        Console.WriteLine("5. Quit");
        Console.Write("Select a choice from the menu: ");
        string answer = Console.ReadLine();
        int choice = int.Parse(answer);
        return choice;
    }

}