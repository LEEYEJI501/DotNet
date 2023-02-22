using System;

namespace NullableTypeDemo
{
    public class NullableTypeDemo
    {
        public static void Main()
        {
            string s = null;
            Console.WriteLine(s);

            //int i = null;
            //Console.WriteLine(i);

            int? i = null;
            Console.WriteLine(i);
            double? d = null;
            Console.WriteLine(d);

            Nullable<int> ii = null;
            Console.WriteLine(ii);
            Nullable<double> dd = null;
            Console.WriteLine(dd);
        }
    }
}
