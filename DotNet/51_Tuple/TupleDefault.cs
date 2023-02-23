using System;

class TupleDefault
{
    static void Main()
    {
        var t = ZeroZero();
        Console.WriteLine($"{t.Item1}, {t.Item2}");
    }

    static (int, int) ZeroZero() => default;
}