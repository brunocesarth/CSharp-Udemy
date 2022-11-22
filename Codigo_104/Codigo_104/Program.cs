using System;

namespace Codigo_104
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
