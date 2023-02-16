using System;

namespace InterfaceNote
{
    interface ICar
    {
        void Go();
    }

    class Car : ICar
    {
        public void Go() => Console.WriteLine("상속한 인터페이스에 정의된 모든 멤버를 반드시 구현해야함.");
    }

    class InterfaceNote
    {
        static void Main()
        {
            var car = new Car();
            car.Go();
        }
    }
}