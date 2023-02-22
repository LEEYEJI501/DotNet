using System;

namespace GenericNote
{
    class Juice { }
    class Coffee { }

    class Cup<T>
    {
        public T Type { get; set; }
    }

    class GenericNote
    {
        static void Main()
        {
            Cup<Juice> juice = new Cup<Juice>();
            juice.Type = new Juice();
            Console.WriteLine(juice.Type.ToString());

            var coffee = new Cup<Coffee>()
            {
                Type = new Coffee()
            };
            Console.WriteLine(coffee.Type.ToString());
        }
    }
}
