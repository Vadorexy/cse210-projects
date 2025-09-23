using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void Display()
    {
        try
        {
            Console.Clear();
        }
        catch (IOException)
        {
            // If Console.Clear() fails while running in VS Code debugger, just ignore it
            Console.WriteLine("\n--- (screen cleared) ---\n");
        }

        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }

    // Hide words not already hidden
    public void HideRandomWords(int count)
    {
        Random rand = new Random();

        // Filter words what are visible
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();

            // remove it so we it doesn't re-hide itself
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}