using System;

class VariableScope
{
    static string globalVariable = "전역변수";

    static void Main()
    {
        string localVariable = "지역변수";
        Console.WriteLine(localVariable);
        Console.WriteLine(globalVariable);
        Test();
    }

    static void Test() => Console.WriteLine(globalVariable);
}