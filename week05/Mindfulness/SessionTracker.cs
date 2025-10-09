using System;
using System.IO;

public class SessionTracker
{
    private string _filePath = "session_log.txt";
    public int BreathingCount { get; private set; }
    public int ReflectionCount { get; private set; }
    public int ListingCount { get; private set; }

    public SessionTracker()
    {
        LoadLog();
    }

    private void LoadLog()
    {
        if (!File.Exists(_filePath))
        {
            BreathingCount = 0;
            ReflectionCount = 0;
            ListingCount = 0;
            return;
        }

        string[] lines = File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            string[] parts = line.Split(':');
            if (parts.Length == 2)
            {
                string activity = parts[0].Trim();
                int count = int.Parse(parts[1].Trim());

                switch (activity.ToLower())
                {
                    case "breathing":
                        BreathingCount = count;
                        break;
                    case "reflection":
                        ReflectionCount = count;
                        break;
                    case "listing":
                        ListingCount = count;
                        break;
                }
            }
        }
    }

    public void SaveLog()
    {
        string[] lines =
        {
            $"Breathing: {BreathingCount}",
            $"Reflection: {ReflectionCount}",
            $"Listing: {ListingCount}"
        };

        File.WriteAllLines(_filePath, lines);
    }

    public void Increment(string activity)
    {
        switch (activity.ToLower())
        {
            case "breathing":
                BreathingCount++;
                break;
            case "reflection":
                ReflectionCount++;
                break;
            case "listing":
                ListingCount++;
                break;
        }

        SaveLog(); // Save immediately after each update
    }

    public void DisplayLog()
    {
        //Console.Clear(); 
        Console.WriteLine("🧘 Session Log 🧘");
        Console.WriteLine("------------------");
        Console.WriteLine($"Breathing Activity: {BreathingCount} times");
        Console.WriteLine($"Reflection Activity: {ReflectionCount} times");
        Console.WriteLine($"Listing Activity: {ListingCount} times");
    }
}