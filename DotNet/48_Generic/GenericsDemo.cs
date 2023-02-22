using System;

namespace GenericsDemo
{
    class Pair<T, V>
    {
        public T First { get; set; }
        public V Second { get; set; }
        
        public Pair(T first, V second)
        {
            First = first;
            Second = second;
        }
    }
    
    class GenericsDemo
    {
        static void Main()
        {
            var my = new Pair<string, bool>("강아지는 귀여워", true);
            Console.WriteLine($"{my.First} : {my.Second}");

            var tuple = new Pair<int, double>(1234, 3.14);
            Console.WriteLine($"{tuple.First}, {tuple.Second}");
        }
    }
}
