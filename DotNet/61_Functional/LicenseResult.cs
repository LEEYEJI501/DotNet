using System;

class LicenseResult
{
    static string GetResultWithStatement(int score)
    {
        string r;
        if (score >= 60)
        {
            r = "합격";
        }
        else {
            r = "불합격";
        }
        return r;
    }

    static string GetResultWithExpression(int score) => score >= 60 ? "합격" : "불합격";

    static void Main()
    {
        Console.WriteLine(GetResultWithStatement(60));

        Console.WriteLine(GetResultWithExpression(60));
    }
}