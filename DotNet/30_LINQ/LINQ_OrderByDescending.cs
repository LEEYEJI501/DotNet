using System;
using System.Collections.Generic;
using System.Linq;

class LINQ_OrderByDescending
{
    static void Main()
    {
        List<string> names = new List<string> { "C#", "React", "Java" };

        var orders = names.OrderByDescending(n => n);

        foreach (var name in orders)
        {
            Console.WriteLine(name);
        }
    }
}