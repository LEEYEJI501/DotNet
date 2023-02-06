using System;

class ConstructorDemo
{
    public ConstructorDemo()
    {
        Console.WriteLine("생성자 호출");
    }
    static void Main()
    {
        ConstructorDemo c = new ConstructorDemo();
}
}