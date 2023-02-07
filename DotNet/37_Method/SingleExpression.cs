using System;

class SingleExpression
{
    static int AddAge(int age) => age + 1;

    static void Main() => Console.WriteLine(AddAge(100));
}