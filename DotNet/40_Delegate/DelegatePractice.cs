using System;

namespace DelegatePractice
{
    public class CarDriver
    {
        public static void GoForward() => Console.WriteLine("직진");
        public static void GoLeft() => Console.WriteLine("좌회전");
        public static void GoRight() => Console.WriteLine("우회전");
        public static void GoBack() => Console.WriteLine("후진");
    }

    public class Insa
    {
        public void Bye() => Console.WriteLine("잘가");
    }

    public delegate void GoHome();

    public class DeletegatePractice
    {
        public delegate void Say();

        private static void Hello() => Console.WriteLine("Hello");
        private static void Hi() => Console.WriteLine("Hi");

        static void Main(string[] args)
        {
            CarDriver.GoLeft(); ;
            CarDriver.GoForward();
            CarDriver.GoRight();
            CarDriver.GoBack();

            GoHome go = new GoHome(CarDriver.GoLeft);
            go += new GoHome(CarDriver.GoForward);
            go += new GoHome(CarDriver.GoRight);
            go += new GoHome(CarDriver.GoBack);
            go();

            Console.WriteLine();

            Say say;
            say = new Say(Hi);
            say += new Say(Hello);
            say();

            Insa insa = new Insa();
            Say say2 = new Say(insa.Bye);
            say2 += new Say(insa.Bye);
            say2();

        }
    }

}