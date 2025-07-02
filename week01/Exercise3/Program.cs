using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("This is the game guess the magic number game. Ready to start it.");
        Random randomNumber = new Random();

        int MAGICNUMBER = randomNumber.Next(1, 101);
        Console.WriteLine("What is your guess?");
        int GUESSNUMBER = int.Parse(Console.ReadLine());

        while (GUESSNUMBER != MAGICNUMBER)
        {
            if (GUESSNUMBER < MAGICNUMBER)
            {
                Console.WriteLine("Higher");
            }
            else if (GUESSNUMBER > MAGICNUMBER)
            {
                Console.WriteLine("Lower");
            }
            Console.WriteLine("What is your guess?");
            string INPUTNUMBER = Console.ReadLine();
            GUESSNUMBER = int.Parse(INPUTNUMBER);
        }
        Console.WriteLine($"You guessed it. The magic number is: {MAGICNUMBER}.");
    }
}