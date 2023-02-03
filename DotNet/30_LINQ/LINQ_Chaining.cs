using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

class LINQ_Chaining
{
    static void Main()
    {
        List<string> names = new List<string> { "C#", "React", "Java" };

        var results = names
                    .Where(name => name.Length >= 2)
                    .OrderBy(n => n);

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
    }
}