using System;
using System.Collections.Generic;

namespace ListOfCategory
{
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    class ListOfCategory
    {
        static void Main()
        {
            var cateogories = new List<Category>()
            {
                new Category() { CategoryId = 1, CategoryName = "Good Book"},
                new Category() { CategoryId = 2, CategoryName = "Good Lecture"},
                new Category() { CategoryId = 3, CategoryName = "Good Computer"}
            };

            foreach (var category in cateogories)
            {
                Console.WriteLine($"{category.CategoryId} - {category.CategoryName}");
            }
        }
    }
}