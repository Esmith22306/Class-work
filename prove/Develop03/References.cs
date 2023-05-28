using System;

public class References
{
    private string _book;
    private int _chapter;
    List<int> _verses =  new List<int>();

    public References(string book, int chapter, int verse)
    {
        _book = book; 
        _chapter = chapter;
        _verses.Add(verse);

    }
 
        public References(string book, int chapter, int startingVerse, int endingVerse)
    {
        _book = book; 
        _chapter = chapter;
        _verses.Add(startingVerse);
        _verses.Add(endingVerse);
    }
    

    
    public string GetReference()
    {
        string verses = (_verses.Count() > 1) ? $"{_verses[0]}-{verses[1]}" : $"{_verses[0]}";
        return $"\"{_book}\"\n{_chapter}: {Verses}";
        
    }

}