using System;

class TryFinallyDemo
{
    static void Main()
    {
        Console.WriteLine("[1] 시작");

        try
        {
            Console.WriteLine("[2] 실행");
            throw new Exception();
        }
        finally
        {
            Console.WriteLine("[3] 종료");
        }
    }
}