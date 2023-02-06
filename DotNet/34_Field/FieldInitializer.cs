using System;

class Say
{
    private string message = "HI";

    public void Hi()
    {
        this.message = "hello";
        Console.WriteLine(this.message);
    }
}

class FieldInitializer
{
    static void Main()
    {
        Say say = new Say();
        say.Hi();
    }
}