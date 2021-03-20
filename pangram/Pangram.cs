using System;
using System.Collections.Generic;
using System.Linq;

public static class Pangram
{
    private const int AlphabetSize = 26;

    public static bool IsPangram(string input) => input
                    .Select(character => character.ToString())
                    .Where(letter => Char.IsLetter(letter.ElementAt(0)))
                    .ToHashSet(StringComparer.OrdinalIgnoreCase).Count() == AlphabetSize;
}
