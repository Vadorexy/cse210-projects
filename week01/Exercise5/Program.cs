using System;

class Program
{
    // 1: Welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // 2: Ask for and return the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // 3: Ask for and return the user's number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4: Square a number
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // 5: Display the result
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }

    // Main function
    static void Main()
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squared = SquareNumber(userNumber);

        DisplayResult(userName, squared);
    }
}