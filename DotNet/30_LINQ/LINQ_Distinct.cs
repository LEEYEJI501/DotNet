using System;
using System.Linq;

class LINQ_Distinct
{
    static void Main()
    {
        var data = Enumerable.Repeat(3, 5);

        var result = data.Distinct();

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }

        int[] arr = { 1, 2, 2, 1, 2 };
        var r = arr.Distinct();

        foreach (var num in r)
        {
            Console.WriteLine(num);
        }
    }
}