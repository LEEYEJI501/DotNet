using System;

namespace DestructorDemo
{
    public class Car
    {
        private string _name;
        public string getName()
        {
            return _name;
        }
        public Car()
        {
            _name = "SUV";
        } 
        public Car(string name)
        {
            this._name= name;
        }
        ~Car()
        {
            Console.WriteLine("[{0} 폐차...]", _name);
        }
    }

    class DestructorDemo
    {
        static void Main()
        {
            Car car1 = new Car();
            Console.WriteLine(car1.getName()); 
            Car car2 = new Car("캠핑카");
            Console.WriteLine(car2.getName());
        }
    }
}