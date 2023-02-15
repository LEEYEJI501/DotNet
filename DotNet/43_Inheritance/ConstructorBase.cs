using System;

namespace ConstructorBase
{
    class Parent
    {
        public Parent(string message) => Console.WriteLine(message);
    }

    class Child : Parent
    {
        public Child(string message) : base(message) { }
    }

    class ConstructorBase
    {
        static void Main()
        {
            string message = "자식 클래스의 생성자를 호출할 때 부모 클래스의 생성자로 전달";
            var child = new Child(message);
        }
    }
}