public class Entry
{
    public string _entryText="";
    public string _promptText="";
    public string _dateToday="";


    public void DisplayEntry()
    {
        Console.WriteLine($"{_dateToday} {_promptText}");
        Console.WriteLine(_entryText);
    }



}