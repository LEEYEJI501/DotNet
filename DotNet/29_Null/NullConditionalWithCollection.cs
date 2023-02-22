using System;
using System.Collections.Generic;

class NullConditionalWithCollection
{
    static void Main()
    {
        List<string> list = null;
        int? numberOfList;

        numberOfList = list?.Count;
        if (numberOfList == null)
        {
            Console.WriteLine($"[1] 리스트 카운트: null");
        }

        list = new List<string>();
        list.Add("안녕하세요."); list.Add("반갑습니다.");

        numberOfList = list?.Count;
        if (numberOfList != null)
        {
            Console.WriteLine($"[2] 리스트 카운트: {numberOfList}");
        }

    }
}