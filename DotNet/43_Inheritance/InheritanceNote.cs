using System;

namespace InheritanceNote
{
    public enum CarType
    {
        전기, 
        내연기관
    }

    public abstract class CarBase
    {
        public abstract void Left();
        public void Back() => Console.WriteLine("후진하다.");
    }

    public class Car : CarBase 
    {
        public override void Left() => Console.WriteLine("좌회전하다.");
        public void Go() => Console.WriteLine("달리다.");
    }

    public class Audi : Car
    {
        public CarType Style { get; set; } = CarType.내연기관;
    }

    public class Tesla : Car
    {
        public CarType Style { get; set; } = CarType.전기;
    }

    class InheritanceNote : Object
    {
        static void Main()
        {
            Audi audi = new Audi();
            audi.Go();
            Console.WriteLine($"{audi.Style}");
            audi.Back();
            audi.Left();

            Tesla tesla = new Tesla();
            tesla.Go();
            Console.WriteLine($"{tesla.Style}");
            tesla.Back();
            tesla.Left();
        }
    }
}