using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference; 
        string[] words = text.Split(" ");
        foreach ( string wordText in words)
        {
            Word word = new  Word(wordText);
            _words.Add(word);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;
        while(hiddenCount < numberToHide)
        {
            if (IsCompletlyHidden())
                {
                    break;
                }
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                hiddenCount ++;
            }
            if (IsCompletlyHidden())
            {
                break;
            }

        }
        
    }
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText();
        foreach(Word word in _words)
        {
            scriptureText += " " + word.GetDisplayText();
        }
        return scriptureText;

    }
    public bool IsCompletlyHidden()
    {
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}