using System;
using System.Collections.Generic;

namespace ListOfObject
{
    class AreaCode
    {
        public string Number { get; set; }
        public string AreaName { get; set; }
    }

    class ListOfObject
    {
        static void Main()
        {
            List<AreaCode> areas = new List<AreaCode>();

            AreaCode seoul = new AreaCode();
            seoul.Number = "02";
            seoul.AreaName = "서울";

            AreaCode sejong = new AreaCode
            {
                Number = "044",
                AreaName = "세종"
            };

            areas.Add(seoul);
            areas.Add(sejong);

            foreach (var area in areas)
            {
                Console.WriteLine($"번호 : {area.Number}, 지역 : {area.AreaName}");
            }
        }
    }
}
