using System;
using System.Collections.Generic;

namespace Codigo_097
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine("Retorno do contains: " + set.Contains("Computer"));

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}
