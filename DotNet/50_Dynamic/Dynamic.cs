using System;

class Dynamic
{
    static void Main()
    {
        dynamic x;
        x = 1234;
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());

        x = "Dynamic Type!";
        Console.WriteLine(x);
        Console.WriteLine(x.GetType());
    }
}
