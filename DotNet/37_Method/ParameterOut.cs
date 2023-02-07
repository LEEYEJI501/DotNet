using System;

class ParameterOut
{
    static void Main()
    {
        int num;

        Do(out num);

        Console.WriteLine($"[2] {num}");
    }

    static void Do(out int num)
    {
        num = 1234;
        Console.WriteLine($"[1] {num}");
    }
}