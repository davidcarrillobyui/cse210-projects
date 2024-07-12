public class Report
{
    // likely to use polymorphims
    // Property for the content of the report
    public string Content { get; set; }

    // Constructor to initialize Report content
    public Report(string content)
    {
        Content = content;
    }
}
