using System;
using System.Collections.Generic;

namespace CollectionInitializers
{
    class Person
    {
        public string Name { get; set; }
    }

    class CollectionInitializers
    {
        static void Main()
        {
            List<Person> people = new List<Person>
            {
                new Person { Name = "leee" },
                new Person { Name = "kimm" },
                new Person { Name = "kwon" }
            };

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}