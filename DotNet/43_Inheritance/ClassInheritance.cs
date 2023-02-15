using System;

namespace ClassInheritance
{
    public class ParentClass : Object
    {
        protected void Print1() => Console.WriteLine("부모 클래스에서 정의한 내용");
    }

    public class ChildClass : ParentClass
    {
        public void Print2() =>
            base.Print1();
    }

    class ClassInheritance : Object
    {
        static void Main()
        {
            ParentClass p = new ParentClass();
            Console.WriteLine(p.ToString());

            ChildClass c = new ChildClass();
            c.Print2();
        }
    }
}