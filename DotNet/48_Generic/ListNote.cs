using System;
using System.Collections.Generic;

namespace ListNote
{
    /// <summary>
    /// 연간 일사량
    /// </summary>
    public class Insolation
    {
        /// <summary>
        /// 월(1 ~ 12)
        /// </summary>
        public int Month { get; set; }
        /// <summary>
        /// 일사량 값
        /// </summary>
        public float Value { get; set; }
    }

    class ListNote
    {
        static void Main()
        {
            List<Insolation> insolations = new List<Insolation>()
            {
                new Insolation { Month = 1, Value = 0.3f },
                new Insolation { Month = 2, Value = 0.6f },
                new Insolation { Month = 3, Value = 0.9f },
                new Insolation { Month = 4, Value = 1.2f }
            };

            insolations.Add(new Insolation() { Month = 5, Value = 1.5f });
            insolations.Add(new Insolation() { Month = 6, Value = 1.8f });
            insolations.Add(new Insolation() { Month = 7, Value = 1.6f });
            insolations.Add(new Insolation() { Month = 8, Value = 1.5f });

            var tempInsolations = new List<Insolation>()
            {
                new Insolation { Month = 9, Value = 1.2f },
                new Insolation { Month = 10, Value = 0.9f },
                new Insolation { Month = 11, Value = 0.6f },
                new Insolation { Month = 12, Value = 0.1f }
            };
            insolations.AddRange(tempInsolations);

            Console.WriteLine("연간 일사량");
            foreach (var insolation in insolations)
            {
                Console.WriteLine($"{insolation.Month:00} - {insolation.Value}");
            }
        }
    }
}
