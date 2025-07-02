using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string USERNAME = PromptUserName();
        int FAVORITENUMBER = PromptUserNumber();
        int SQUAREDNUMBER = SquareNumber(FAVORITENUMBER);

        DisplayResult(USERNAME, SQUAREDNUMBER);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please type your name: ");
        string NAME = Console.ReadLine();
        return NAME;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please type your favorite number: ");
        string FNUMBER = Console.ReadLine();
        int F_NUMBER = int.Parse(FNUMBER);
        return F_NUMBER;
    }
    static int SquareNumber(int NUMBER)
    {
        return NUMBER * NUMBER;
    }

    static void DisplayResult(string NAME, int SQUARED)
    {
        Console.WriteLine($"Your name is: {NAME} and the square of your favorite number is: {SQUARED}.");
    }
    //Wrote and tested functions to get user input, square a number, and display results. Learning about functions and use the functions inside of the MAIN function.
}