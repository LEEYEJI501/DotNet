using System;

namespace InterfaceExample
{
    public interface ICarStandard
    {
        void Left();
    }
    public abstract class KS
    {
        public abstract void Back();
        public void Fly() => Console.WriteLine("날다");
    }

    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    public sealed class Car : MyCar, ICarStandard
    {
        public void Left() => Console.WriteLine("좌회전");
        public void Run() => Console.WriteLine("직진");
    }

    public class InterfaceExample
    {
        static void Main()
        {
            Car car = new Car();
            car.Run();
            car.Right();
            car.Back();
            car.Left();
            car.Fly();
        }
    }
}