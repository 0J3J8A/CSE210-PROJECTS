using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Please enter a number to add to the list:");
        string N_1 = Console.ReadLine();
        int N1 = int.Parse(N_1);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_2 = Console.ReadLine();
        int N2 = int.Parse(N_2);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_3 = Console.ReadLine();
        int N3 = int.Parse(N_3);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_4 = Console.ReadLine();
        int N4 = int.Parse(N_4);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_5 = Console.ReadLine();
        int N5 = int.Parse(N_5);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_6 = Console.ReadLine();
        int N6 = int.Parse(N_6);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_7 = Console.ReadLine();
        int N7 = int.Parse(N_7);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_8 = Console.ReadLine();
        int N8 = int.Parse(N_8);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_9 = Console.ReadLine();
        int N9 = int.Parse(N_9);
        Console.WriteLine("Please enter a number to add to the list:");
        string N_10 = Console.ReadLine();
        int N10 = int.Parse(N_10);


        List<int> NUMBERSLIST = new List<int>();
        NUMBERSLIST.Add(N1);
        NUMBERSLIST.Add(N2);
        NUMBERSLIST.Add(N3);
        NUMBERSLIST.Add(N4);
        NUMBERSLIST.Add(N5);
        NUMBERSLIST.Add(N6);
        NUMBERSLIST.Add(N7);
        NUMBERSLIST.Add(N8);
        NUMBERSLIST.Add(N9);
        NUMBERSLIST.Add(N10);

        int TOTAL = 0;
        foreach (int i in NUMBERSLIST)
        {
            TOTAL += i;
        }
        Console.WriteLine($"The total of the numbers in the list is: {TOTAL}");

        int LISTSIZE = (NUMBERSLIST.Count);
        int AVERAGE = TOTAL / LISTSIZE;
        Console.WriteLine($"The average of the list is: {AVERAGE}");

        int MAXNUMBER = NUMBERSLIST[0];
        foreach (int i in NUMBERSLIST)
        {
            if (i > MAXNUMBER)
            {
                MAXNUMBER = i;
            }
        }
        Console.WriteLine($"The maxium number is: {MAXNUMBER}");
    }
}