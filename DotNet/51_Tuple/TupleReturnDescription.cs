using System;

class TupleReturnDescription
{
    static (int, int) Tally1()
    {
        var r = (12, 3);
        return r;
    }

    static (int Sum, int Count) Tally2() => (45, 6);

    static void Main()
    {
        var t1 = Tally1();
        Console.WriteLine($"Sum : {t1.Item1}, Count : {t1.Item2}");

        var t2 = Tally2();
        Console.WriteLine($"Sum : {t2.Sum}, Count : {t2.Count}");
    }
}