using System;
using System.Collections;

class IEnumeratorDemo
{
    static void Main()
    {
        string[] names = { "닷넷코리아", "비주얼아카데미" };

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        IEnumerator list = names.GetEnumerator();
        while (list.MoveNext())
        {
            Console.WriteLine(list.Current);
        }
    }
}