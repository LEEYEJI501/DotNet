using System;
using System.Linq;

class LINQ_All
{
    static void Main()
    {
        bool[] complete = { true, true, true };

        // 배열 또는 컬렉션의 모든 항복이 true일때에만 true 반환
        Console.WriteLine(complete.All(c => c == true));
    }
}