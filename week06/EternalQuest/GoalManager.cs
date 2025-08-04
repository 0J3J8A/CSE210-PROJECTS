using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    //  START THE PROGRAM
    public void Start()
    {
        Console.WriteLine("================================");
        Console.WriteLine("   Welcome to Eternal Quest!   ");
        Console.WriteLine("    Goal Tracking Program      ");
        Console.WriteLine("================================");

        // Initialize with empty goals and zero score
        _score = 0;
        _goals = new List<Goal>();

        while (true)
        {
            Console.WriteLine("\n--- Main Menu ---");
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List All Goals");
            Console.WriteLine("3. Save Progress");
            Console.WriteLine("4. Load Progress");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6":
                    Console.WriteLine("\nThank you for using Eternal Quest!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    //  GOALS 
    public void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Musical Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                Console.WriteLine("\nSelect instrument:");
                Console.WriteLine("1. Guitar");
                Console.WriteLine("2. Piano");
                Console.WriteLine("3. Sing");
                Console.Write("Enter your choice: ");
                string instrumentChoice = Console.ReadLine();

                string instrument = instrumentChoice switch
                {
                    "1" => "Guitar",
                    "2" => "Piano",
                    "3" => "Sing",
                    _ => "Unknown"
                };

                Console.Write("Enter the song name: ");
                string songName = Console.ReadLine();
                Console.Write("Enter the author/composer: ");
                string author = Console.ReadLine();
                Console.Write("Enter the target date (yyyy-mm-dd): ");
                DateTime targetDate = DateTime.Parse(Console.ReadLine());

                _goals.Add(new MusicalGoal(name, description, points, instrument, songName, author, targetDate));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
        Console.WriteLine("Goal created successfully!");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\n=== YOUR GOALS ===");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        Console.WriteLine("\nSelect a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            Goal goal = _goals[goalNumber];
            goal.RecordEvent();
            _score += goal.GetPoints();

            if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
            {
                _score += checklistGoal.GetBonus();
                Console.WriteLine($"★ Bonus! +{checklistGoal.GetBonus()} points!");
            }

            Console.WriteLine($"\n★ Recorded: {goal.GetShortName()} (+{goal.GetPoints()} points)");
            Console.WriteLine($"Total Score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    //  SAVE
    public void SaveGoals()
    {
        Console.Write("Enter filename to save (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);  // SAVE SCORE
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(parts[4]);
                    var simpleGoal = new SimpleGoal(name, description, points);
                    if (isComplete) simpleGoal.RecordEvent();
                    _goals.Add(simpleGoal);
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    for (int j = 0; j < amountCompleted; j++) checklistGoal.RecordEvent();
                    _goals.Add(checklistGoal);
                    break;
                case "MusicalGoal":
                    string instrument = parts[4];
                    string songName = parts[5];
                    string author = parts[6];
                    DateTime targetDate = DateTime.Parse(parts[7]);
                    bool musIsComplete = bool.Parse(parts[8]);
                    var musicalGoal = new MusicalGoal(name, description, points, instrument, songName, author, targetDate);
                    if (musIsComplete) musicalGoal.RecordEvent();
                    _goals.Add(musicalGoal);
                    break;
            }
        }
        Console.WriteLine($"Loaded {_goals.Count} goals. Current score: {_score}");
    }
}