public class Prompt
{

    List<string> _usedPrompts = new List<string>();
    List<string> _prompts = new List<string>();
    
    public Prompt()
    {
     
     _prompts.Add ("How was your day? ");

    }

    int _randomInt()
    {
        var random = new Random();
        var randomNumber = random.Next(0, _prompts.Count);
        return randomNumber;
    }

    public string GetRandomPrompt(int _randomInt)
    {
        string prompt = _prompts[_randomInt].MoveToUsed();
        return prompt;
        
    }

    public void MoveToUsed()
    {
        string prompt = _prompts[index];
        _prompts.Remove(index);
        _usedPrompts.Add(index);

    
    }

    public bool CheckForPrompts()
    {


    }

    public void Shuffleprompts()
    {

    }

}