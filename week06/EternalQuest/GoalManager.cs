using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public int GetScore() => _score;

    public void CreateGoal()
    {
        Console.WriteLine("\nChoose a goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Choice: ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter point value: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times to complete? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].GetName()} - {_goals[i].GetDescription()}");
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("\nWhich goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        Goal goal = _goals[index];
        goal.RecordEvent();
        _score += goal.GetPoints();

        if (goal is ChecklistGoal cg && cg.IsComplete())
        {
            _score += cg.GetBonus();
        }
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(filename))
        {
            output.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                output.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];
            string name = parts[1];
            string desc = parts[2];
            int points = int.Parse(parts[3]);

            switch (type)
            {
                case "SimpleGoal":
                    bool complete = bool.Parse(parts[4]);
                    SimpleGoal sg = new SimpleGoal(name, desc, points);
                    if (complete) sg.RecordEvent();
                    _goals.Add(sg);
                    break;

                case "EternalGoal":
                    _goals.Add(new EternalGoal(name, desc, points));
                    break;

                case "ChecklistGoal":
                    int bonus = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int count = int.Parse(parts[6]);
                    ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);
                    for (int j = 0; j < count; j++) cg.RecordEvent();
                    _goals.Add(cg);
                    break;
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }
}