using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
               "This activity will help you relax by walking you through slow breathing. Clear your mind and focus on your breath.")
    {
    }

    public void Run()
    {
        Start();
        SafeClear();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in... ");
            Countdown(4);
            Console.Write("Now breathe out... ");
            Countdown(6);
        }

        End();
    }
}