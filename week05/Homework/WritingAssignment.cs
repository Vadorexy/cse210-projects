public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor uses base() to pass studentName and topic to the parent class
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    // Method specific to WritingAssignment
    public string GetWritingInformation()
    {
        // Access base class data via GetStudentName() method
        return $"{_title} by {GetStudentName()}";
    }
}