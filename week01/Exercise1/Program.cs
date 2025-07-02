using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise1 Project.");
        Console.WriteLine("What is your First Name? ");
        string FIRSTNAME = Console.ReadLine();
        Console.WriteLine("What is your Last Name? ");
        string LASTNAME = Console.ReadLine();
        Console.WriteLine($"Your name is {LASTNAME}, {FIRSTNAME} {LASTNAME}.");
    }
    // Wrote and tested a program that asks for the user's name and displays it. Learning about Input and Output
}