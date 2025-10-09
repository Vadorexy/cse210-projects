using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _rand = new Random();
    private List<string> _unusedQuestions;

    public ReflectionActivity()
        : base("Reflection",
               "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
               "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        Start();
        SafeClear();

        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press ENTER to continue...");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        ShowSpinner(4);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            if (_unusedQuestions.Count == 0)
                _unusedQuestions = new List<string>(_questions); // reset when used

            int index = _rand.Next(_unusedQuestions.Count);
            string question = _unusedQuestions[index];
            _unusedQuestions.RemoveAt(index);

            Console.WriteLine($"> {question}");
            ShowSpinner(5);
            Console.WriteLine();
        }

        End();
    }
}