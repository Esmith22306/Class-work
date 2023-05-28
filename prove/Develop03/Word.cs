using system;

public class Word
{

    private string _word;
    private bool _isShown;

    public Word(string word)
    {
        _word = word;
        _isShown = true;
    }   

    public string GetWordAsString ()
    {
        return _word;
    }

    public bool CheckIfShown()
    {
        return _isShown;
    }

    public void hideWord()
    {
        _isShown = false;
        string blankedWord = "";
        foreach(char letter in _word)
        {
            if (Char.IsLetter(letter))
            {
                blankedWord += "_";
            }
            else 
            {
                blankedWord += $"{letter}";
            }
        }
        _word = blankedWord;
    }



}