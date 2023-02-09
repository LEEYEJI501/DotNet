using Bar;
using System;
using System.Collections;

class YieldReturn
{
    static IEnumerable MultiData()
    {
        yield return "Hello";
        yield return "World";
        yield return "C#";
    }

    static void Main()
    {
        foreach (var item in MultiData())
        {
            Console.WriteLine(item);
        }
    }
}