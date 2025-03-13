public class Entry
{
    public string _promptText;
    public string _entryText;
    public DateTime _date;

    public Entry(string prompt, string response)
    {
        _promptText = prompt;
        _entryText = response;
        _date = DateTime.Now;
    }

    public string MakeEntryText()
    {
        return $"Date: {_date.ToShortDateString()} - Prompt: {_promptText}\n{_entryText}\n";
    }
    public void Display()
    {
        Console.WriteLine( $"Date: {_date.ToShortDateString()} - Prompt: {_promptText}\nResponse: {_entryText}\n");
    }
}