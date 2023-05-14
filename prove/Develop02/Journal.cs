using System.IO; 
using System;
public class Journal
{
    // variables
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string _userFileName;
    public Journal()
    {

    }
    public void Display()
    {
        Console.WriteLine("\n->->->->->-> Journal Entries <-<-<-<-<-<-");
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
        Console.WriteLine("->->->->->-> End <-<-<-<-<-<-");
    }
    public void CreateJournalFile()
    {
        Console.Write("Enter file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n->->-> {_userFileName} has been created! <-<-<-\n");
            Console.Write("->->->Your journal entries have been saved. <-<-<-\n");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"\n->->-> {_userFileName} already exits. <-<-<-\n");
            Console.Write("->->->Your journal entries have been added. <-<-<-\n");
            AppendJournalFile(_userFileName);
        }
    }
    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime};{journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }
    public void AppendJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append:true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._dateTime};{journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }
    public void LoadJournalFile()
    {
        Console.Write("What is your file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";
        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");
                JournalEntry entry = new JournalEntry();
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];
                _journal.Add(entry);
            }
        }
    }
}