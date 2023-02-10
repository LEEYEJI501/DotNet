using System;

class DelegateSample
{
    static void Eat() => Console.WriteLine("먹어");
    static void Run() => Console.WriteLine("뛰어");
    static void Say() => Console.WriteLine("말해");

    delegate void Move();

    static void Main()
    {
        Move goMove = new Move(Eat);
        goMove += Run;
        goMove += Say;
        goMove -= Say;
        goMove += delegate { Console.WriteLine("춤춰"); }; // 무명 메서드 / 익명 함수
        goMove += () => Console.WriteLine("누워"); // 람다식

        goMove(); // goMove.Invoke();

        // 내장된 대리자 형식을 통해서 직접 대리자 개체 생성 : Func<T>, Action<T>, Predicate<T>, ...
        Action move = Eat;
        move += Run;
        move += delegate { Console.WriteLine("춤춰"); }; ;
        move += () => Console.WriteLine("누워");
        move(); // 트리거

        Action go = () => Console.WriteLine("웃어");
        go();

        RunLamda(() => Console.WriteLine("매개 변수로 람다식(함수 이름, 무명 메서드) 전달"));
    }
    static void RunLamda(Action action) => action();
}