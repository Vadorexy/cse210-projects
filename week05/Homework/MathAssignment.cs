public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Constructor for derived class
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
        : base(studentName, topic) // Calls base constructor
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method specific to math assignments
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}