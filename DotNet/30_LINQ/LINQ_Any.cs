using System;
using System.Linq;

class LINQ_Any
{
    static void Main()
    {
        int[] arr = { 1, 2, 3 };
        bool bln = arr.Any(num => num == 2);

        if(bln)
        {
            Console.WriteLine("조건에 맞는 요소가 있다.");
        }
    }
}