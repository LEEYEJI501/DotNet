using System;

namespace PolymorphismDemo
{
    public abstract class Animal
    {
        public abstract string Cry();
    }
    public class Dog : Animal
    {
        public override string Cry() => "멍멍멍";
    }
    public class Cat : Animal
    {
        public override string Cry() => "야오오옹";
    }
    public class Trainer
    {
        public void DoCry(Animal animal)
        {
            // 어떤 메서드가 실행될지는 런타임 시점에 알 수 있다.
            Console.WriteLine("{0}", animal.Cry());
        }
    }

    class PolymorphismDemo
    {
        static void Main()
        {
            Console.WriteLine((new Dog()).Cry());
            Console.WriteLine((new Cat()).Cry());

            Animal dog = new Dog();
            Console.WriteLine(dog.Cry());
            Animal cat = new Cat();
            Console.WriteLine(cat.Cry());

            Trainer trainer = new Trainer();
            trainer.DoCry(new Dog());
            trainer.DoCry(new Cat());

        }
    }
}