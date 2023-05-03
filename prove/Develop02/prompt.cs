public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();
    
    public Prompt()
    {
        _prompts.Add("A thorn and a rose from your day? "); 
        
    }

    public string GetRandomPrompt()
    {
        return "How was your day?";
    }



}