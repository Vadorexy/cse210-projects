using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _currentCount++;
        Console.WriteLine($"You recorded progress on '{GetName()}' and earned {GetPoints()} points!");

        if (_currentCount == _targetCount)
        {
            Console.WriteLine($"Goal complete! Bonus {_bonus} points!");
        }
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_bonus}|{_targetCount}|{_currentCount}";
    }

    public override string GetStatus()
    {
        return IsComplete() ? $"[X] Completed {_currentCount}/{_targetCount}" : $"[ ] Completed {_currentCount}/{_targetCount}";
    }

    public int GetBonus() => _bonus;
    public int GetCount() => _currentCount;
}