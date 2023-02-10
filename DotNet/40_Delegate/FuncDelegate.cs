using System;
using System.ComponentModel;

class FuncDelegate
{
    static void Main()
    {
        Console.WriteLine(Add(3, 5));

        Func<int, int, string> AddDelegate = Add;
        Console.WriteLine(AddDelegate(3, 5));
        
        Func<int, int, string> AddLambda = (a, b) => (a + b).ToString();
        Console.WriteLine(AddLambda(3, 5));
    }

    static string Add(int a, int b) => (b + a).ToString();
}