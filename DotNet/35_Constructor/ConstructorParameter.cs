using System;

namespace ConstructorParameter
{
    class My
    {
        private string _name;
        private int _age;
        public My(string name, int age)
        {
            this._name = name;
            this._age = age;
        }
        public void PrintMy()
        {
            Console.WriteLine($"이름 : {this._name}, 나이 : {this._age}");
        }
    }
    class ConstructorParameter
    {
        static void Main()
        {
            My my = new My("Leeyeji", 29);
            my.PrintMy();
        }
    }
}