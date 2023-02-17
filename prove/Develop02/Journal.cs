using System;
using System.IO; 

// class Journal
public class Journal
{
    // Variable for the class
    public string _fileName;

    // Response for EACH entry
   
    public List<Entry> _entries = new List<Entry>();

    // Method to display the journal
    
    public void DisplayJournal()
    {   
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            
        }
    }

    // Method to save the file
    public void SaveFile()
    {
        Console.WriteLine("What would you like to name this file? ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} - {entry._promptQuestion} - {entry._userResponse}");
                
            }
        }
    }

    // Method to load the file
    public void LoadFile()
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            Entry theEntry = new Entry();
            string[] parts = line.Split("-");

            theEntry._date = parts[0];
            theEntry._promptQuestion = parts[1];
            theEntry._userResponse = parts[2];

            _entries.Add(theEntry);
        }
        DisplayJournal();
    }

}