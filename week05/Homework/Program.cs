using System;

class Program
{
    static void Main(string[] args)
    {
        // WritingAssignment object
        WritingAssignment writing = new WritingAssignment(
            "Ibeziem Wisdom",
            "Modern Literature",
            "The Psycology of Money"
        );

        // Display summary
        Console.WriteLine(writing.GetSummary());

        // Display writing info
        Console.WriteLine(writing.GetWritingInformation());
    }
}