using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number < 1)
            throw new ArgumentOutOfRangeException();

        if (number == 1)
            return 0;

        int counter = 0;
            
        while(number != 1)
        {
            number = (number % 2 == 0) ? number /= 2 : number = (3 * number) + 1; 
            counter ++;
        }
        
        return counter;
    }


}