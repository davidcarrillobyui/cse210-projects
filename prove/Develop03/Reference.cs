public class Reference
{
    private string _book; // Name of the book
    private int _chapter; // Chapter number
    private int _startVerse; // Starting verse number
    private int? _endVerse; // Ending verse number (nullable for single verse references)

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    // Method to get the formatted reference as a string
    public string GetFormattedReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }
    }
}
