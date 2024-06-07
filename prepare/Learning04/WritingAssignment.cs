public class WritingAssignment : Assigment

{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base (studentName, topic)
    {
        _title = title;

    }

    public string GetWrittingInfo()
    {
        return $"{_title} by {_studentName}";
    }


}