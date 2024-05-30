public class Word
{
    private string text; // Actual word text
    private bool isHidden; // Indicates if the word is hidden

    // Constructor to initialize the word
    public Word(string text)
    {
        this.text = text;
        this.isHidden = false; // Initially, the word is not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        isHidden = false;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return isHidden;
    }

    // Method to get the rendered text based on visibility state
    public string GetRenderedText()
    {
        return isHidden ? new string('_', text.Length) : text;
    }
}
