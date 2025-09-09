using System;

class Program
{
    static void Main()
    {
        string playAgain = "yes";
        Random random = new Random();

        while (playAgain.ToLower() == "yes")
        {
            // Generating random number between 1 and 100
            int magicNumber = random.Next(1, 101);
            int guess = -1;

            Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");

            // Loop for correct guess
            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                // Validate input
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed it!");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}