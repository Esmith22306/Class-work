using System.IO; 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.Clear();
        Console.Write("\nWelcome to the Journal Program!\n");
        // Create new journal reference/list
        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();
        while (action != 5)
        {
            // Ask for user input (1-5)//Call Choices
            action = Choices();
            switch (action)
            {
                case 1: // Write Journal Entry
                    //string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();
                    JournalEntry entry = new JournalEntry();
                    //entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;
                    Console.Write($"{prompt}\n");
                    Console.Write("--> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;
                    journal._journal.Add(entry);
                    Console.Clear();
                    break;
                case 2: // Display Journal Entries
                    journal.Display();
                    break;
                case 3: // Load text file
                    journal.LoadJournalFile();
                    break;
                case 4: // Save to text file
                    journal.CreateJournalFile();
                    break;
                case 5: // Quit
                Console.WriteLine("\nThank you for using the JournalProgram!\n");
                break;
                default:
                Console.WriteLine($"\nSorry the option you entered is notvalid!");
                break;
            }
        }
    }
        static int Choices()
        {
            Console.Write("\nPlease select one of the following choices:\n");
            Console.Write("1. Write\n");
            Console.Write("2. Display\n");
            Console.Write("3. Load\n");
            Console.Write("4. Save\n");
            Console.Write("5. Quit\n");
            Console.Write("\nWhat would you like to do? ");

            string choices = @"";
            Console.Write(choices);

            string userInput = Console.ReadLine();
            int action = 0;
            
            action = int.Parse(userInput);
            return action;
        }

    static string GetDateTime()
    // GetTing the date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        return currentDateTime;
    }
    static void AddJournalEntry()
    // Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, "");
    }
}