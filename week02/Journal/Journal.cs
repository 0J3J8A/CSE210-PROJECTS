using System.IO;
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
            Console.WriteLine($"Date: {entry._Date}. Prompt: {entry._Prompt}");
            Console.WriteLine($"Response: {entry._Response}\n");
            Console.WriteLine("----------------------------");
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in Entries)
            {
                outputFile.WriteLine($"{entry._Date}|{entry._Prompt}|{entry._Response}"); // SEPARATOR SIGN "|"
            }
        }
        Console.WriteLine($"Journal saved to {filename} successfully!");
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|'); //USING THE SEPARATOR SIGN OF LINE 33
            if (parts.Length == 3)
            {
                Entry newEntry = new Entry(parts[1], parts[2]) {_Date = parts[0] };
                Entries.Add(newEntry);
            }
        }
        Console.WriteLine($"File loaded! Entries added: {lines.Length}");
    }
}