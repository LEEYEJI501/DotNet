using System;

class My { }

class Your
{
    public override string ToString()
    {
        return "return new string";
    }
}

class ToStringMethod
{
    static void Main()
    {
        My my = new My();
        Console.WriteLine(my);

        Your your = new Your();
        Console.WriteLine(your);
    }
}