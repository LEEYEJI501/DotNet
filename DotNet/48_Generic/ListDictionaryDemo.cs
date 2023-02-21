using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace ListDictionaryDemo
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }

    class ListDictionaryDemo
    {
        static void Main()
        {
            Book b1 = new Book();
            b1.Title = "ASP.NET";
            b1.Author = "lee";
            b1.ISBN = "1234";

            Book b2 = new Book()
            {
                Title = "C#",
                Author = "lee",
                ISBN = "4321"
            };

            ListDictionary Id = new ListDictionary();
            Id.Add("첫번째", b1);
            Id.Add("두번째", b2);

            Console.WriteLine(((Book)Id["첫번째"]).Title);

            Book b = (Book)Id["두번째"];
            Console.WriteLine("{0}, {1}, {2}", b.Title, b.Author, b.ISBN);
        }
    }
}
