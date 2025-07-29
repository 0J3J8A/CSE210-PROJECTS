using System;
using System.Collections.Generic;

public class BodyScanActivity : Activity
{
    private List<string> _bodyParts = new List<string>
    {
        "feet", "legs", "hips", "back", "shoulders", 
        "arms", "hands", "neck", "face", "head"
    };

    public BodyScanActivity()
    {
        _name = "Body Scan";
        _description = "This activity will guide you through a body scan meditation to help you release tension and become more aware of your body.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        Console.WriteLine("Lie down or sit comfortably. We'll scan each part of your body for tension.");
        Console.WriteLine("Focus on each area, then consciously relax it.");
        Console.WriteLine("Press enter when you're ready to begin...");
        Console.ReadLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int secondsPerPart = _duration / _bodyParts.Count;

        foreach (string part in _bodyParts)
        {
            if (DateTime.Now >= endTime) break;
            
            Console.WriteLine($"Bring your attention to your {part}...");
            Console.Write($"Relax your {part}... ");
            ShowCountDown(secondsPerPart > 3 ? 3 : secondsPerPart);
            Console.WriteLine();
        }

        Console.WriteLine("Now bring your awareness to your body as a whole...");
        ShowSpinner(5);

        DisplayEndingMessage();
    }
}