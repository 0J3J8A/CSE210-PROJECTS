using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("Please give me your grade percentage, I'm going to calculate your grade.");
        string GRADEPERCENTAGE = Console.ReadLine();
        int NUMBERPERCENTAGE = int.Parse(GRADEPERCENTAGE);

        string LETTER = "";

        if (NUMBERPERCENTAGE >= 90)
        {
            LETTER = "A";
        }
        else if (NUMBERPERCENTAGE >= 80)
        {
            LETTER = "B";
        }
        else if (NUMBERPERCENTAGE >= 70)
        {
            LETTER = "C";
        }
        else if (NUMBERPERCENTAGE >= 60)
        {
            LETTER = "D";
        }
        else
        {
            LETTER = "F";
        }

        Console.WriteLine($"Your grade is: {LETTER}");
        
        if (NUMBERPERCENTAGE >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("I know that you can do it, the next time would be better.");
        }     
    }
}