using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! This is my initial program");
        Add(3, 6);
        Subtract(23, 12);
        Multiply(4, 7);
        Addrevert(23, 15);
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

    static void Multiply(int x, int y)
    {
        Console.WriteLine($"\n{x} * {y}");
        Console.WriteLine($"Product: {x * y}");
    }
    static void Addrevert(int x, int y)
    {
        Console.WriteLine($"\n{x} + {y}");
        Console.WriteLine($"Sum: {x + y}");
    }
}
