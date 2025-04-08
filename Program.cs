﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! This is my initial program");
        Add(3, 6);
        Subtract(23, 12);
    }

    static void Add(int x, int y)
    {
        Console.WriteLine($"\n{x} + {y}");
        Console.WriteLine($"Sum: {x + y}");
    }

    static void Subtract(int x, int y)
    {
        Console.WriteLine($"\n{x} - {y}");
        Console.WriteLine($"Difference: {x - y}");
    }
}