using System;

class ObsoleteDemo
{
    [Obsolete("Using New Member Method")]
    public static void OldMethod() => Console.WriteLine("Old Method");

    public static void NewMethod() => Console.WriteLine("New Method");

    static void Main()
    {
        OldMethod();
    }
}