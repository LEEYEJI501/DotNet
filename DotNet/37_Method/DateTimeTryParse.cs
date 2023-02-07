using System;

class DateTimeTryParse
{
    static void Main()
    {
        DateTime dt;

        if (DateTime.TryParse("2023-02-06", out dt)) 
        {
            Console.WriteLine(dt);
        }
        else
        {
            Console.WriteLine("날짜 형식으로 변환할 수 없습니다.");
        }

        if (DateTime.TryParse("2023-02-06", out var myDate))
        {
            Console.WriteLine(myDate);
        }
    }
}