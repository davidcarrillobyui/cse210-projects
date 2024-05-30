public class Reference
{
    private string book; // Name of the book
    private int chapter; // Chapter number
    private int startVerse; // Starting verse number
    private int? endVerse; // Ending verse number (nullable for single verse references)

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = verse;
        this.endVerse = null;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    // Method to get the formatted reference as a string
    public string GetFormattedReference()
    {
        if (endVerse.HasValue)
        {
            return $"{book} {chapter}:{startVerse}-{endVerse}";
        }
        else
        {
            return $"{book} {chapter}:{startVerse}";
        }
    }
}
