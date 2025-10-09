using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private Random _rand = new Random();
    private List<string> _unusedPrompts;

    public ListingActivity()
        : base("Listing",
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _unusedPrompts = new List<string>(_prompts);
    }

    public void Run()
    {
        Start();
        SafeClear();

        // Pick a random prompt without repeating question until all used
        if (_unusedPrompts.Count == 0)
            _unusedPrompts = new List<string>(_prompts);

        int index = _rand.Next(_unusedPrompts.Count);
        string prompt = _unusedPrompts[index];
        _unusedPrompts.RemoveAt(index);

        Console.WriteLine($"Prompt: {prompt}\n");
        Console.WriteLine("Take a few seconds to think before starting...");
        Countdown(5);

        Console.WriteLine("Start listing! (Press ENTER after each item)");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        End();
    }
}