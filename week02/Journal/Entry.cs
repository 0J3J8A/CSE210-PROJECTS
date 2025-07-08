public class Entry
{
    public string _Date { get; set; }
    public string _Prompt { get; set; }
    public string _Response { get; set; }

    public Entry(string prompt, string response)
    {
        _Date = DateTime.Now.ToString("MM/dd/yyyy");
        _Prompt = prompt;
        _Response = response;
    }
}