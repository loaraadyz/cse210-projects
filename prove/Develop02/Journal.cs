using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries= new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving file...\n");
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"DATE: {entry._dateToday} TIME: {entry._time} \nPROMPT: {entry._promptText}");
                outputFile.WriteLine($"ENTRY: {entry._entryText}\n");
            }
            
        }
    }

    public void LoadFromFile(string file)
    {

        Console.WriteLine("\nReading file...\n");
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }


    }




}
    

    