public class Resume
{
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Resume for {_personName}");
        Console.WriteLine("Currently Jobs: ");
        
        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}