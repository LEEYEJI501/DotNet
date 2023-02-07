using System;

class paramsDemo
{
    static void Main()
    {
        Console.WriteLine(SumAll(3, 5));
        Console.WriteLine(SumAll(3, 5, 7));
        Console.WriteLine(SumAll(3, 5, 7, 9));
    }

    static int SumAll(params int[] nums)
    {
        int sum = 0;
        foreach ( int n in nums)
        {
            sum += n;
        }
        return sum;
    }
}