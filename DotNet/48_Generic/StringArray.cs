using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace StringArray
{
    class StringArray
    {
        static void Main()
        {
            var a1 = new string[] { "Red", "Blue", "Black" };

            var a2 = new List<string>();
            a2 = a1.ToList();

            IEnumerable<string> a3 = a1;

            var a4 = a3.ToList();

            foreach (var arr in a3)
            {
                Console.WriteLine(arr);
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{a1[i]}, {a2[i]}, {a4[i]}");
            }
        }
    }
}
