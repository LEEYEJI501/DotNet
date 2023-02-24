using System;

class ConcurrencyFor
{
    static void Main()
    {
        for (int i = 0; i < 200_000; i++)
        {
            Console.WriteLine(i);
        }
    }
}