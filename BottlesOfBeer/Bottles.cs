﻿namespace BottlesOfBeer;

public class Bottles
{
    public string Song()
    {
        return Verses(99, 0);
    }

    public string Verses(int starting, int ending)
    {
        IList<string> verses = new List<string>();

        for (int i = starting; i >= ending; i--)
        {
            verses.Add(Verse(i));
        }

        return string.Join("\n", verses);
    }

    public string Verse(int number)
    {
        switch(number)
        {
            case 0:
                return "No more bottles of beer on the wall, " +
                    "no more bottles of beer.\n" +
                    "Go to the store and buy some more, " +
                    "99 bottles of beer on the wall.\n";
            case 1:
                return "1 bottle of beer on the wall, " +
                    "1 bottle of beer.\n" +
                    "Take it down and pass it around, " +
                    "no more bottles of beer on the wall.\n";
            case 2:
                return "2 bottles of beer on the wall, " +
                    "2 bottles of beer.\n" +
                    "Take one down and pass it around, " +
                    "1 bottle of beer on the wall.\n";
            default:
                return $"{number} bottles of beer on the wall, " +
                    $"{number} bottles of beer.\n" +
                    "Take one down and pass it around, " +
                    $"{number-1} bottles of beer on the wall.\n";
        }
    }
}
