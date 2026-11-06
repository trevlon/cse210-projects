using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.IO.Enumeration;

public class Journal
{

    // Member variables
    public string _write = "Write";
    public string _display = "Display";
    public string _save = "Save";
    public string _load = "Load";
    public string _quit = "Quit";

    public string fileName= "myFile.txt";

    // Method to output member variables
    public void JournalChoices()
    {
        Console.WriteLine($"1.{_write}");
        Console.WriteLine($"2.{_display}");
        Console.WriteLine($"3.{_save}");
        Console.WriteLine($"4.{_load}");
        Console.WriteLine($"5.{_quit}");
    }
    
    // Make a list to store the entries
    public List<Entry> _entries = new List<Entry>();
    
    // A method to store the entries from the Entry class from Entry.cs 
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Disply the entries
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {

        foreach(Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._response);
            }    
        }
    }

    public void LoadFromFile(string fileName)
    {
       // Prevents duplicating entries
       _entries.Clear(); 

       string [] lines = File.ReadAllLines(fileName);

       for (int i = 0; i < lines.Length; i +=3 )
        {
            string date = lines[i];
            string prompt = lines[i + 1];
            string response = lines[i + 2];

            Entry entry = new Entry(date, prompt, response);
            _entries.Add(entry);
        }
    }
}