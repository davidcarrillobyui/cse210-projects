public class Report
{
    // Property for the content of the report
    public string Content { get; private set; }

    // Constructor to initialize Report content
    public Report(string content)
    {
        Content = content;
    }
}
