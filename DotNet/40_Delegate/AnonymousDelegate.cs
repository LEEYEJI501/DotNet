using System;

class AnonymousDelegate
{
    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = delegate ()
        {
            Console.WriteLine("반가워요.");
        };
        say();
    }
}