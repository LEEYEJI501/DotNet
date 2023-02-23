using System;
using System.ComponentModel;
using System.Globalization;

class LocalFunctionDescription
{
    static void Main()
    {
        int[] numbers = { 0b1, 0B10, 0B0100, 0B0000_1000 };
        var (sum, count) = Tally(numbers);
        Console.WriteLine($"Sum : {sum}, Count : {count}");
    }

    static (int, int) Tally(int[] values)
    {
        var r = (Sum: 0, Count: 0);
        foreach(var v in values)
        {
            Add(v, 1);
        }
        return r;

        void Add(int s, int c)
        {
            r.Sum += s;
            r.Count += c;
        }
    }
}