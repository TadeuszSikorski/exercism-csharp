﻿using System;

public static class Grains
{
    public static ulong Square(int n) => 
          n < 1 || n > 64 
        ? throw new ArgumentOutOfRangeException() 
        : (ulong) Math.Pow(2, n - 1);

    public static ulong Total() => (ulong) Math.Pow(2, 64) - 1;
}