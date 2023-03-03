using System;
using System.Reflection.Emit;

class HigerOrderFunction
{
    static void FunctionParameterWithAction(Action<string> action, string message)
    {
        action(message);
    }

    static void FunctionParameterWithFunc(Func<int, int> func, int number)
    {
        int result = func(number);
        Console.WriteLine($"{number} * {number} = {result}");
    }

    static Action<string> FunctionReturnValueWithAction() =>
        msg => Console.WriteLine($"{msg}");

    static Func<int, int> FunctionReturnValueWithFunc()
        => x => x * x;

    static void Main()
    {
        Action<string> action = message => Console.WriteLine(message);
        FunctionParameterWithAction(action, "고차 함수 : 매개 변수");

        Func<int, int> func = x => x * x;
        FunctionParameterWithFunc(func, 3);

        FunctionReturnValueWithAction()("고차 함수 : 반환값");

        int number = 3;
        int result = FunctionReturnValueWithFunc()(number);
        Console.WriteLine($"{number} * {number} = {result} ");
    }

}