using System;
using System.Diagnostics;

namespace InterfaceFriends
{
    public interface IStandard { void Run(); }

    public abstract class KS
    {
        public abstract void Back();
        public void Left() => Console.WriteLine("좌회전");
    }

    public partial class MyCar : KS
    {
        public override void Back() => Console.WriteLine("후진");
    }
    public partial class MyCar : KS
    {
        public void Right() => Console.WriteLine("우회전");
    }

    public sealed class Car : MyCar, IStandard
    {
        public void Run() => Console.WriteLine("전진");
    }

    class InterfaceFriends
    {
        static void Main()
        {
            Car cla = new Car();
            cla.Run();
            cla.Left();
            cla.Right();
            cla.Back();
        }
    }
}