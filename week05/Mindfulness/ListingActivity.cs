using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> //prompts of the activity instructions
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; // DESCRIPTION AS IN THE INSTRUCTIONS
        _count = 0;
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5); //COUNTDOWN
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> items = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!"); //displays back the number of items that were entered.
        
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Count)];
    }
}