using System;

class ParameterRef
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine($"[1] {num}");

        Do(ref num);

        Console.WriteLine($"[3] {num}");
    }

    static void Do(ref int num)
    {
        num = 30;
        Console.WriteLine($"[2] {num}");
    }
}