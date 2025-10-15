using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You recorded '{GetName()}' and earned {GetPoints()} points!");
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }

    public override string GetStatus()
    {
        return "[∞]";
    }
}