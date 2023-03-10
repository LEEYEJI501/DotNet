using Bar;
using System;
using System.Collections;

namespace IndexerAndIteratorDemo
{

    class Car
    {
        private string[] names;
        public Car(int length)
        {
            names = new string[length];
        }
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < names.Length; i++) 
            {
                yield return names[i];
            }
        }
    }

    class IndexerAndIterator
    {
        static void Main()
        {
            Car cars = new Car(3);
            cars[0] = "CLA";
            cars[1] = "CLS";
            cars[2] = "AMG";

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}