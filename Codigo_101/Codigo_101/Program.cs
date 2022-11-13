using System;
using System.Collections.Generic;

namespace Codigo_101
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> CourseA = new HashSet<int>();
            HashSet<int> CourseB = new HashSet<int>();
            HashSet<int> CourseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                CourseA.Add(matricula);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                CourseB.Add(matricula);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int matricula = int.Parse(Console.ReadLine());
                CourseC.Add(matricula);
            }

            HashSet<int> all = new HashSet<int>(CourseA);
            all.UnionWith(CourseB);
            all.UnionWith(CourseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
