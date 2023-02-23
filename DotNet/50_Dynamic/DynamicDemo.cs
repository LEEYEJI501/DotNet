using System;

class DynamicDemo
{
    static void Main()
    {
        string ss = "HIHI";
        Console.WriteLine(ss.Length);

        var vs = "Nice to meet you";
        Console.WriteLine(vs.Length);

        dynamic ds = "see you again";
        Console.WriteLine(ds.Length);

        ds = 1234;
        Console.WriteLine(ds * 10);
    }
}