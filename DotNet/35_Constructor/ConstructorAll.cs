using System;

namespace ConstructorAll
{
    public class Person
    {
        private static readonly string name;
        private int age;

        static Person() { name = "Leeyeji"; }
        public Person() { age = 23; }
        public Person(int age)
        {
            this.age = age;
        }

        public static void Show()
        {
            Console.WriteLine("이름 : {0}", name);
        }

        public void Print()
        {
            Console.WriteLine("나이: {0}", age);
        }

        class ConstructorAll
        {
            static void Main()
            {
                Person.Show();

                (new Person()).Print();
                (new Person(22)).Print();
            }
        }
    }
}