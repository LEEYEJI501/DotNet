using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LinqCollectionDemo
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class NewType
    {
        public string Maker { get; set; }
    }

    class LinqCollectionDemo
    {
        static void Main()
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { Make = "Camper", Model = "Camper1", Year = 2015 },
                new Car() { Make = "Camper", Model = "Camper3", Year = 2016 },
                new Car() { Make = "SUV", Model = "AAA", Year = 2017 },
                new Car() { Make = "SUV", Model = "BBB", Year = 2018 },
                new Car() { Make = "SUV", Model = "CCC", Year = 2019 },
                new Car() { Make = "SUV", Model = "DDD", Year = 2020 }
            };

            var campers = from car in cars
                          where car.Make == "Camper"
                          select car;
            var newCars = from car in cars
                          where car.Year >= 2015
                          select car;

            var orderedCars = from car in cars
                              orderby car.Year descending
                              select car;
            foreach (var c in orderedCars)
            {
                Console.WriteLine("{0}, {1}, {2}", c.Make, c.Model, c.Year);
            }

            var newObject = from car in cars
                            orderby car.Year ascending
                            select new NewType { Maker = car.Make };
            foreach (var c in newObject)
            {
                Console.WriteLine("{0}", c.Maker );
            }

        }
    }
}