using System;
using System.Collections.Generic;

namespace DictionaryOfString
{
    class DictionaryOfString
    {
        static void Main()
        {
            Dictionary<string, string> nickNames = new Dictionary<string, string>();
            nickNames.Add("Taeyo", "태오");
            nickNames.Add("RedPlus", "레드플러스");
            nickNames.Add("Itist", "아이티스트");

            if (nickNames.ContainsKey("RedPlus"))
            {
                Console.WriteLine(nickNames["RedPlus"]);
            }
        }
    }
}
