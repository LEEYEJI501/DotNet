using System;

namespace PropertyAll
{
    public class Car
    {
        private string color;

        public Car()
        {
            this.color = "black";
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public string GetColor()
        {
            return color;
        }

        public string Color
        {
            get {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string Make
        {
            get
            {
                return "korea car";
            }
        }

        private string _Type;
        public string Type
        {
            set
            {
                _Type = value;
            }
        }

        public string Name { get; set; }

        class PropertyAll
        {
            static void Main()
            {
                Car car1 = new Car();
                car1.SetColor("red");
                Console.WriteLine(car1.GetColor());

                Car whiteCar = new Car();
                whiteCar.Color = "White";
                Console.WriteLine(whiteCar.Color);

                Car k = new Car();
                Console.WriteLine(k.Make);

                Car car = new Car();
                car.Type = "SUV";

                Car myCar = new Car();
                myCar.Name = "sosocar";
                Console.WriteLine(myCar.Name);
            }
        }
    }
}