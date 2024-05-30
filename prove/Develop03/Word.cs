public class Word
{
    private string _text; // Actual word text
    private bool _isHidden; // Indicates if the word is hidden

    // Constructor to initialize the word
    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Initially, the word is not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Method to get the rendered text based on visibility state
    public string GetRenderedText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
