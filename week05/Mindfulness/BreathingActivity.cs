public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing"; 
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."; // DESCRIPTION AS IN THE INSTRUCTIONS
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);//COUNTDOWN
            Console.WriteLine();
            Console.Write("Now breathe out... ");
            ShowCountDown(6); //COUNTDOWN
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}