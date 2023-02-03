using System;

namespace ObjectNote
{
    public class Counter
    {
        public void GetTodayVisitCount()
        {
            Console.WriteLine("오늘 123123명이 접속했습니다.");
        }
    }
    class ObjectNote
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.GetTodayVisitCount();
        }
    }
}