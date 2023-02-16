using System;

public interface IRepository
{
    void Get();
}

public class Repository : IRepository
{
    public void Get() => Console.WriteLine("Get() 메서드를 구현해야함");
}

class InterfacePractice
{
    static void Main()
    {
        IRepository repository = new Repository();
        repository.Get();
    }
}