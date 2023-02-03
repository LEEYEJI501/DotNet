using System;

namespace TypeDefinitionWithUsing
{
    using Project = Gilbut.Education.CSharp.Lecture;

    public class TypeDefinitionWithUsing
    {
        public static void Main(string[] args)
        {
            Gilbut.Education.CSharp.Lecture l = new Gilbut.Education.CSharp.Lecture();
            Console.WriteLine(l);

            Project p = new Project();
            Console.WriteLine(p);
        }
    }
}

namespace Gilbut
{
    namespace Education
    {
        namespace CSharp
        {
            public class Lecture
            {
                public override string ToString()
                {
                    return "Lecture class";
                }
            }
        }
    }
}