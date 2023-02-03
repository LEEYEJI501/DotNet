using System;
using System.Linq;
using System.Threading;

class LINQ_Take
{
    static void Main()
    {
        var data = Enumerable.Range(0, 100);

        var five = data.Take(3);

        foreach (var f in five) 
        {
            Console.WriteLine(f);
        }

        var even = data.Where(n => n % 2 == 0).Take(5);

        foreach (var e in even)
        {
            Console.WriteLine(e);
        }
    }
}