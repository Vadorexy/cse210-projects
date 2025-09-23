using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // library of 5 different scriptures
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new ScriptureReference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life."
            ),

            new Scripture(
                new ScriptureReference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding; " +
                "in all your ways submit to him, and he will make your paths straight."
            ),

            new Scripture(
                new ScriptureReference("Psalm", 23, 1, 3),
                "The Lord is my shepherd, I lack nothing. " +
                "He makes me lie down in green pastures, " +
                "he leads me beside quiet waters, he refreshes my soul."
            ),

            new Scripture(
                new ScriptureReference("Psalm", 91, 1, 3),
                "Whoever dwells in the shelter of the Most High will rest in the shadow of the Almighty. " +
                "I will say of the Lord, 'He is my refuge and my fortress, my God, in whom I trust.' " +
                "Surely he will save you from the fowler’s snare and from the deadly pestilence."
            ),

            new Scripture(
                new ScriptureReference("Genesis", 1, 1, 5),
                "In the beginning God created the heavens and the earth. " +
                "Now the earth was formless and empty, darkness was over the surface of the deep, " +
                "and the Spirit of God was hovering over the waters. " +
                "And God said, 'Let there be light,' and there was light. " +
                "God saw that the light was good, and he separated the light from the darkness. " +
                "God called the light 'day,' and the darkness he called 'night.' " +
                "And there was evening, and there was morning—the first day."
            )
        };

        // Pick random scripture
        Random rand = new Random();
        Scripture scripture = library[rand.Next(library.Count)];

        while (true)
        {
            scripture.Display();

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            if (scripture.AllHidden())
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}