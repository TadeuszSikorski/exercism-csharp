using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> nucleotideCounts = new Dictionary<char, int>
        {
            ['A'] = 0,
            ['C'] = 0,
            ['G'] = 0,
            ['T'] = 0
        };

        foreach (var nucleotide in sequence)
        {
            if (!nucleotideCounts.ContainsKey(nucleotide)) throw new ArgumentException();

            nucleotideCounts[nucleotide] += 1;
        }

        return nucleotideCounts;
    }
}
