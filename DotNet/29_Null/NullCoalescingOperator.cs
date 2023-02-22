using System;

class NullCoalescingOperator
{
    static void Main()
    {
        int? value = null;
        int defaultValue = value ?? -1;
        Console.WriteLine(defaultValue);
    }
}