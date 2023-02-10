using System;

class DelegateDemo
{
    static void Hi() => Console.WriteLine("안녕");

    delegate void SayDelegate();

    static void Main()
    {
        SayDelegate say = Hi;
        say();

        var hi = new SayDelegate(Hi);
        hi();
    }
}