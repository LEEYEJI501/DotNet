using System;

class NullCoalescing
{
    static void Main()
    {
        var result = "";
        var message = "";

        message = null;
        result = message;
        Console.WriteLine(result);

        message = "있는 값";
        result = message ?? "기본값" ;
        Console.WriteLine(result);
    }
}