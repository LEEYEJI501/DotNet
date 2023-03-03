using System;
using System.Linq;

class AggregateDemo
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };

        int max = numbers.Aggregate((f, s) => f > s ? f : s);
        Console.WriteLine(max);

        int min = numbers.Aggregate((c, n) => c < n ? c : n);
        Console.WriteLine(min);
    }
}