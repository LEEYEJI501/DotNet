using System;

class TryCatch
{
    static void Main()
    {
        try
        {
            int[] arr = new int[2];
            arr[100] = 1234;
        }
        catch
        {
            Console.WriteLine("에러 발생");
        }
    }
}