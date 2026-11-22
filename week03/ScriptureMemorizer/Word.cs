public class Word(string text)
{

    private string _text = text;
    
    private bool _isHidden;
    public void Hide()
    {
       _isHidden = true;
    }
    public void show()
    {
        _isHidden = false;
        
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "__";
        }
        return _text;
        
    }
    
}