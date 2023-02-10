using System;

class DelegateParameter
{
    delegate void Runner();

    static void Main()
    {
        RunnerCall(new Runner(Go));
        RunnerCall(new Runner(Back));
    }

    static void RunnerCall(Runner runner) => runner();
    static void Go() => Console.WriteLine("직진");
    static void Back() => Console.WriteLine("후진");

}