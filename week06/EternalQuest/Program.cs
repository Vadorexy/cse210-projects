using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine($"Current Score: {manager.GetScore()} points");
            Console.Write("Select a choice: ");

            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        manager.CreateGoal();
                        break;
                    case 2:
                        manager.ListGoals();
                        break;
                    case 3:
                        manager.SaveGoals();
                        break;
                    case 4:
                        manager.LoadGoals();
                        break;
                    case 5:
                        manager.RecordEvent();
                        break;
                    case 6:
                        Console.WriteLine("Goodbye, Goal getter!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, try again.");
                        break;
                }
            }
        }
    }
}