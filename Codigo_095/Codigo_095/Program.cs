using System;

namespace Codigo_095
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Maria";
            string b = "Maria";
            Console.WriteLine("Equals: " + a.Equals(b));

            Console.WriteLine("GetHashCode Maria: " + a.GetHashCode());
            Console.WriteLine("GetHashCode Alex/Maria: " + b.GetHashCode());
        }
    }
}
