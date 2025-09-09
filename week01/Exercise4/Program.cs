using System;
using System.Collections.Generic;
using System.Linq; // Needed to Sum, Average, Max, and sorting helpers

class Program
{
    static void Main()
    {
        // Create a list for user input
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a series of numbers (enter 0 to stop):");

        while (true)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                break; // stop input when user enters 0
            }

            numbers.Add(num);
        }

        // if user entered 0 immediately
        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        // Compute total, average, and max
        int total = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        // Display results
        Console.WriteLine($"\nTotal: {total}");
        Console.WriteLine($"Average: {average:F2}");
        Console.WriteLine($"Maximum: {max}");

        // Sort the list (Optional)
        numbers.Sort();

        // Display sorted numbers
        Console.WriteLine("\nSorted List:");
        foreach (int n in numbers)
        {
            Console.Write(n + " ");
        }
    }
}