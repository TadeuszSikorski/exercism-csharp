using System;
using System.Collections.Generic;
using System.Linq;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    private static List<int> GetAllFactors(int number)
    {
        List<int> factorsOfNumbers = new List<int>();
        int max = (int) Math.Sqrt(number);

        var factors = Enumerable.Range(1, max);

        foreach (int factor in factors)
        {
            if (number % factor == 0) 
            {
                factorsOfNumbers.Add(factor);
                    
                if (factor != (number/factor))
                    factorsOfNumbers.Add(number/factor);
            }
        }
        
        return factorsOfNumbers;
    }

    public static Classification Classify(int number)
    {
        var allFactors = GetAllFactors(number);
        allFactors.RemoveAll(factor => factor.Equals(number));

        int sumOfAllFactors = allFactors.Sum();

        return _ switch 
        {
            sumOfAllFactors == number   => Classification.Perfect
            sumOfAllFactors > number    => Classification.Abundant
            sumOfAllFactors < number    => Classification.Deficient
            _   => throw new ArgumentOutOfRangeException()
        }    
    }
        
        
        
}
