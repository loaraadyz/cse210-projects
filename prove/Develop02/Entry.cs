public class Entry
{
    public string _entryText="";
    public string _promptText="";
    public string _dateToday="";
    public string _time="";

    public void DisplayEntry()
    {
        Console.WriteLine($"DATE: {_dateToday} TIME: {_time} \nPROMPT: {_promptText}");
        Console.WriteLine($"ENTRY: {_entryText}\n");
    }



}