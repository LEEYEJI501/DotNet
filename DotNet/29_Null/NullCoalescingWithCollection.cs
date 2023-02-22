using System;
using System.Collections.Generic;

class NullCoalescingWithCollection
{
    static void Main()
    {
        int num;
        List<string> list;

        list = null;
        num = list?.Count ?? 0;
        Console.WriteLine($"[1] 컬렉션 카운트: {num}");

        list = new List<string>(); list.Add("또 만나요.");
        num = list?.Count ?? 0;
        Console.WriteLine($"[2] 컬렉션 카운트: {num}");
    }
}
