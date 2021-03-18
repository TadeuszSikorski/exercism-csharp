using System;
using System.Linq;

public static class Acronym
{
    public static string Abbreviate(string phrase) {
        char[] separators = new char[] { ' ', '-', '_' };
        var words = phrase.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        return new string(words.Select(x => char.Parse(x.Substring(0, 1).ToUpper())).ToArray());
    }
}