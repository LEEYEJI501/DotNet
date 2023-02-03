using System;

public class CategoryClass
{
    public void Print(int i) => Console.WriteLine($"카테고리 {i}");
}

class ClassArray
{
    static void Main()
    {
        CategoryClass[] category = new CategoryClass[3];

        category[0] = new CategoryClass();
        category[1] = new CategoryClass();
        category[2] = new CategoryClass(); 

        for (int i = 0; i < category.Length; i++)
        {
            category[i].Print(i);
        }
    }
}