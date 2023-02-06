using System;

namespace FieldNote
{
    class Person
    {
        private string name = "Leeyeji";
        private const int age = 29;
        private readonly string _NickName = "gamja";
        private string[] _websites = { "Tistory", "Github" };
        private object all = DateTime.Now.ToShortTimeString();

        public void ShowProfile()
        {
            string r =
                $"{name}, {age}, {_NickName}, {String.Join(",", _websites)}" + 
                $"{Convert.ToDateTime(all).ToShortTimeString()}";
            Console.WriteLine(r);
        }
    }

    class FieldNote
    {
        static void Main()
        {
            Person person = new Person();
            person.ShowProfile();
        }
    }
}