using System;

class TryCatchDemo
{
    static void Main()
    {
        try
        {
            int now = DateTime.Now.Second;
            Console.WriteLine($"[0] 현재 초 : {now}");

            int result = 2 / (now % 2);
            Console.WriteLine("[1] 홀수 초 정상 처리");
        }
        catch
        {
            Console.WriteLine("[2] 짝수 초 런타임 에러 발생");
        }
    }
}