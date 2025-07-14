using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        // USING THE FRACTION CLASS
        Fraction defaultFraction = new Fraction();
        Console.WriteLine($"Default Fraction: {defaultFraction.GetFractionString()}");
        Console.WriteLine($"Default Fraction Result: {defaultFraction.GetDecimalValue()}");

        Fraction topFraction = new Fraction(3);
        Console.WriteLine($"Fraction 1: {topFraction.GetFractionString()}");
        Console.WriteLine($"Fraction 1 Result: {topFraction.GetDecimalValue()}");

        Fraction bothFraction = new Fraction(3,4);
        Console.WriteLine($"Fraction 2: {bothFraction.GetFractionString()}");
        Console.WriteLine($"Fraction 2 Result: {bothFraction.GetDecimalValue()}");

    }
}