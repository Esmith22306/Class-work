using System.IO; 
using System;
// A code template for the category of things known as Journal Prompts
public class JournalPrompt
{
    // The C# convention is to start member variables with an underscore _
    public static string[] _prompt = 
    {
        "What was the most beautiful thing that you saw today?",
        "What was a rose and a thorn from your day? ",
        "What would you change about your day if you could have a do over?",
        "How are you feeling right now?",
        "What is a recent daydream that you had?",
        "How would rank this day compared to others?",
        "What is the most powerful emotion that you have felt today?",
        "When was the last time that you felt the spirit in your life?",
        "Who was the most interesting person that you met today?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);
    public JournalPrompt()
    {

    }
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }
    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        return journalPrompt;
    
    }
    }