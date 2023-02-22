using System;
using System.Net.Configuration;

namespace MyExtensions
{
    static class StringExtension
    {
        public static string Five(this String message) => message.Substring(0, 5);
        public static string Ten(this String message) => message.Substring(0, 10);
        public static string AddElipsis(this String message) => message + "...";
        public static string AddElipsis(this String message, string elipsis)
            => $"{message}{elipsis}";
    }

    class MyExtensions
    {
        static void Main()
        {
            string message = "안녕하세요. 반갑습니다. 또 만나요.";
            Console.WriteLine(message.Ten().Five().AddElipsis());
            Console.WriteLine(message.Ten().Five().AddElipsis("____반가워요."));
        }
    }
}