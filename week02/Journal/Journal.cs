public class Journal
{
    public List<Entry> Entries { get; } = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        Entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries found. Your journal is empty.\n");
            return;
        }

        Console.WriteLine("YOUR JOURNAL ENTRIES");
        foreach (Entry entry in Entries)
        {
            Console.WriteLine($"Date: {entry.Date}. Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
            Console.WriteLine("----------------------------");
        }
    }

}