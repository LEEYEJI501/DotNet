using System;

namespace NullableOf
{
    class NullableOf
    {
        static void Main()
        {
            Nullable<bool> bln = null;

            if (bln.HasValue == true)
            {
                Console.WriteLine($"bln 변수의 값은 {bln.Value}입니다.");
            }
            else {
                Console.WriteLine("bln 변수의 값은 null 입니다.");
            }
        }

    }
}
