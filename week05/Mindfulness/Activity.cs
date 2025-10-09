using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void Start()
    {
        SafeClear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine($"{_description}\n");

        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(3);
    }

    public virtual void End()
    {
        Console.WriteLine("\nWell done! You’ve completed the activity.");
        ShowSpinner(3);
        Console.WriteLine($"You spent {_duration} seconds in the {_name} Activity.");
        ShowSpinner(3);
    }

    protected void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % spinner.Length;
        }
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
    protected void SafeClear()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // Fallback if console doesn't support clearing
            Console.WriteLine("\n---------------------------------------\n");
        }
    }
}