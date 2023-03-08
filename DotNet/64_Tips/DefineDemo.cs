using System;

class DefineDemo
{
    static void Main()
    {
#if YES
// #define YES가 정의되어있으면 현재 구문 실행
Console.WriteLine("YES");
#else
        Console.WriteLine("NO");
#endif
    }
}