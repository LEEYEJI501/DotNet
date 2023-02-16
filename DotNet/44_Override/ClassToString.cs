using System;

namespace ClassToString {

    class Person
    {
        private string name;
        public Person(string name)
        {
            this.name = name;
        }

        public override string ToString() => $"[Person Class : {this.name}]";

    }
    class ClassToString
    {
        static void Main()
        {
            Person person = new Person("이예지");
            Console.WriteLine(person);
        }
    }
}