using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello! This is my initial program");
        Add(3, 6);
        Subtract(23, 12);
        Multiply(4, 7);
        Divide(12, 5);
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

    static void Divide(decimal x, decimal y)
    {
        Console.WriteLine($"\n{x} / {y}");
        if (y != 0)
            Console.WriteLine($"Quotient: {x / y:F2}");
        else
            Console.WriteLine("Cannot divide by zero.");

    }
}
