using System;
using System.Linq;

class EnumerableDemo
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 5);
        foreach (var num in numbers)
            Console.Write("{0}\t", num);
        Console.WriteLine();

        var sameNumbers = Enumerable.Repeat(-1, 5); 
        foreach (var num in sameNumbers)
            Console.Write("{0}\t", num);
        Console.WriteLine();
    }
}