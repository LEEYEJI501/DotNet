using System;
using System.Security.AccessControl;

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
        protected string LeftMessage { get; private set; } = "좌회전하다."; // 자식에게만 멤버 노출
    }

    public class Car : CarBase 
    {
        public CarType Style { get; private set; }
        public Car(CarType carType)
        {
            this.Style = carType;
        }
        public override void Left() => Console.WriteLine(base.LeftMessage);
        public void Go() => Console.WriteLine("달리다.");
    }

    public class Audi : Car
    {
        public Audi() : this(CarType.내연기관) { }
        public Audi(CarType carType) : base(carType) { }
    }

    public class Tesla : Car
    {
        public Tesla() : this(CarType.전기) { }
        public Tesla(CarType carType) : base(carType) { }
    }

    // 봉인 클래스 sealed
    public sealed class Future : Car
    {
        public Future() : this(CarType.전기) { }
        public Future(CarType carType) : base(carType) { }
        public new void Go()
        {
            base.Go();
            Console.WriteLine("날다.");
        }
    }

    //public class OtherFuture : Future { }

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

            Future future = new Future();
            future.Go();

        }
    }
}