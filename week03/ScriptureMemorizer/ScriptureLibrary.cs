using System;
using System.Collections.Generic;
using System.IO;

class ScriptureLibrary
{//USING PRIVATE VARIABLES
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLibrary(string filename)
    {
        ScripturesFromFile(filename);
    }

    private void ScripturesFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('/');
            if (parts.Length == 2)
            {
                Reference reference = ParseReference(parts[0]);
                if (reference != null)
                {
                    _scriptures.Add(new Scripture(reference, parts[1]));
                }
            }
        }
    }

    private Reference ParseReference(string referenceText)
    {
        string[] bookParts = referenceText.Split(' ');
        if (bookParts.Length < 2) return null;

        string book = string.Join(" ", bookParts, 0, bookParts.Length - 1);
        string versePart = bookParts[bookParts.Length - 1];

        string[] chapterVerseParts = versePart.Split(':');
        if (chapterVerseParts.Length != 2) return null;

        int chapter = int.Parse(chapterVerseParts[0]);
        string verses = chapterVerseParts[1];

        if (verses.Contains('-'))
        {
            string[] verseParts = verses.Split('-');
            return new Reference(book, chapter, int.Parse(verseParts[0]), int.Parse(verseParts[1]));
        }
        return new Reference(book, chapter, int.Parse(verses));
    }

    public Scripture GetRandomScripture() //GETTER
    {
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }
}

//THESE CLASS WAS CREATED TO USE A FILE THAT STORES THE SCRIPTURES
//THE FILE WOULD NEED TO BE IN THE SAME FOLDER OF THE PROGRAM
//THE CONTENT OF THE FILE WOULBE THE FOLLOWING FORMAT:
//BOOK CHAPTER:VERSE / CONTENT
// OR
//BOOK CHAPTER:VERSE_START - VERSE_END / CONTENT
//THE SIGN  /  IS THE SEPARATOR SIGN USING IN LINE 20