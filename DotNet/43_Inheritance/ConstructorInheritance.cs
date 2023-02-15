using System;

namespace ConstructorInheritance
{
    public class Parent
    {
        public string word { get; set; }
        public Parent(string word)
        {
            this.word = word;
        }
    }

    public class Child : Parent
    {
        public Child() : this("[1] 매개변수가 없는 생성자 실행") { }

        public Child(string message) : base(message) { }
        public void Say() => Console.WriteLine(base.word);
    }

    class ConstructorInheritance
    {
        static void Main()
        {
            (new Child()).Say();
            (new Child("[2] 매개변수가 있는 생성자 실행")).Say();
        }
    }

}