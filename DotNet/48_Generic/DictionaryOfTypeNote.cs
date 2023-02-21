using System;
using System.Collections.Generic;

namespace DictionaryOfTypeNote
{
    class DictionaryOfTypeNote
    {
        static void Main()
        {
            Dictionary<int, double> keyValuePairs = new Dictionary<int, double>();

            for (int i = 0; i <= 12; i++)
            {
                keyValuePairs.Add(i, 0.0);
            }

            keyValuePairs[1] = 10.01;
            keyValuePairs[2] = 20.02;

            for(int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"{i}월 - {keyValuePairs[i]}kw 사용");
            }
        }
    }
}
