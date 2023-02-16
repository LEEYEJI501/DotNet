﻿using System;

namespace InterfaceInheritance
{
    interface IAnimal
    {
        void Eat();
    }

    interface IDog
    {
        void Yelp();
    }

    class Dog : IAnimal, IDog
    {
        public void Eat() => Console.WriteLine("먹다.");
        public void Yelp() => Console.WriteLine("짖다.");
    }

    class InterfaceInheritance
    {
        static void Main()
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Yelp();
        }
    }
}