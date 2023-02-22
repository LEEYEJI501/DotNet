using System;

class NullConditional
{
    static void Main()
    {
        int? len;
        string message;

        message = null;
        len = message?.Length;
        if (len == null)
        {
            Console.WriteLine("message는 null입니다.");
        }

        message = "HI HELLO";
        len = message?.Length;
        if (len != null)
        {
            Console.WriteLine($"message는 {len}자 입니다.");
        }
    }
}