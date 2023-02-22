using System;

namespace NullCoalescingNote
{
    class NullCoalescingNote
    {
        static void Main()
        {
            string nullValue = null;
            string message = "";

            nullValue = null;
            if (nullValue == null)
            {
                message = "[1] null이면 새로운 값으로 초기화합니다.";
            }
            Console.WriteLine(message);

            nullValue = "Hello";
            message = nullValue ?? "[2] null이면 새로은 값으로 초기화합니다.";
            Console.WriteLine(message);
        }
    }
}
