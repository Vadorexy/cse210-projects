using System;

class Program
{
    static void SafeClear()
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
    static void Main(string[] args)
    {
        SessionTracker tracker = new SessionTracker();

        while (true)
        {
            SafeClear();
            Console.WriteLine("Mindfulness Program 🌿");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Session Log");
            Console.WriteLine("5. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    new BreathingActivity().Run();
                    tracker.Increment("breathing");
                    break;

                case "2":
                    new ReflectionActivity().Run();
                    tracker.Increment("reflection");
                    break;

                case "3":
                    new ListingActivity().Run();
                    tracker.Increment("listing");
                    break;

                case "4":
                    SafeClear();
                    tracker.DisplayLog();
                    Console.WriteLine("\nPress ENTER to return to the menu...");
                    Console.ReadLine();
                    break;

                case "5":
                    tracker.SaveLog();
                    Console.WriteLine("Goodbye! Keep practicing mindfulness 🌸");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }

            Console.WriteLine("\nPress ENTER to return to the main menu...");
            Console.ReadLine();
        }
    }
}