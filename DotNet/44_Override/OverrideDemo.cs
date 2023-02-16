using System;

namespace OverrideDemo
{
    class Parent
    {
        protected void Say() => Console.WriteLine("부모_안녕하세요.");
        protected void Run() => Console.WriteLine("부모_달리다.");
        public virtual void Walk() => Console.WriteLine("부모_걷다.");
        public virtual void Work() => Console.WriteLine("부모_프로그래머");
    }
    
    class Child : Parent
    {
        public void Say() => Console.WriteLine("자식_안녕하세요.");
        public new void Run() => Console.WriteLine("자식_달리다.");
        public override void Walk() => base.Walk();
        public override void Work() => Console.WriteLine("자식_프로게이머");
    }

    class OverrideDemo
    {
        static void Main()
        {
            Child child = new Child();
            child.Say(); // 아무것도 안붙이고 오버라이드
            child.Run(); // 자식 메서드에 new 키워드 붙여서 재정의
            child.Walk(); // 부모 메서드에 virtual을 붙여서 오버라이드
            child.Work(); // 부모 메서드에 virtual을 붙여서 오버라이드 + 기능 재정의
        }
    }
}