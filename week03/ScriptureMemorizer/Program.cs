using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        ScriptureLibrary library = new ScriptureLibrary("scriptures.txt"); //name of the file with the scriptures
        Scripture scripture = library.GetRandomScripture();

        while (!scripture.Hidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit") //USING ToLower() JUST IN CASE THE USER USES UPPER
            {
                Console.WriteLine("Finishing the program, thankss.");//MSG of finished
                return;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden! Press any key to exit."); //MSG of finished
        Console.ReadKey();
    }
}