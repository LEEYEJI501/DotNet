using System;

class DynamicBinding
{
    static void Main()
    {
        dynamic now = DateTime.Now;
        int hour = now.Hour;
        Console.WriteLine(hour);
        //Console.WriteLine(now.NoProperty); // DateTime에 NoProperty에 대한 정의 없음
    }
}