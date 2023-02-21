using System;
using System.Collections.Generic;

namespace CollectionMerge
{
    class First
    {
        public string A { get; set; }
        public string B { get; set; }
    }

    class Second
    {
        public string B { get; set; }
        public string C { get; set; }
    }

    class Merge
    {
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
    }

    class CollectionMerge
    {
        static void Main()
        {
            var first = new List<First>()
            {
                new First() { A = "F1A", B = "F1B" },
                new First() { A = "F2A", B = "F2B" }
            };

            var second = new List<Second>()
            {
                new Second() { B = "S1B", C = "S1C" },
                new Second() { B = "S2B", C = "S2C" }
            };

            var merge = new List<Merge>();

            for(int i = 0; i < first.Count; i++)
            {
                merge.Add(new Merge() { A = first[i].A, B = first[i].B });
            }

            foreach (var s in second)
            {
                merge.Add(new Merge() { B = s.B, C = s.C });
            }

            Console.WriteLine($"{"A ",5} {"B ",5} {"C ",5}");
            foreach (var m in merge)
            {
                Console.WriteLine($"{m.A,5} {m.B,5} {m.C,5}");
            }
        }
    }
}
