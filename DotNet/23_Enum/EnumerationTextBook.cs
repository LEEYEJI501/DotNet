using System;

class EnumerationTextBook
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Red");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.White;
        Console.WriteLine($"Green & {nameof(ConsoleColor.White)}");
        Console.ResetColor();

    }
}