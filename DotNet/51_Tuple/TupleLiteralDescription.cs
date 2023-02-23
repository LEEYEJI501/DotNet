using System;

class TupleLiteralDescription
{
    static void Tally()
    {
        var r = (12, 34, 56);
        Console.WriteLine($"{r.Item1}, {r.Item2}, {r.Item3}");
    }
    static void Main() => Tally();
}