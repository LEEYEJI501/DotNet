using System;

class NullableTypeCheck
{
    static void Main()
    {
        int? x = null;
        int y = x ?? 100;
        int z = x ?? default(int);

        Console.WriteLine($"y: {y}, z : {z}");
    }
}