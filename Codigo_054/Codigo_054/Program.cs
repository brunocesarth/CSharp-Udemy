using System;

namespace Codigo_054 {
    class Program {
        static void Main(string[] args) {
            DateTime d = DateTime.Now;

            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);
            DateTime d4 = d.AddDays(7);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

            Console.WriteLine("-------------------");

            DateTime d5 = new DateTime(2000, 10, 15);
            DateTime d6 = new DateTime(2000, 10, 18);

            TimeSpan t = d6.Subtract(d5); //Data final subtrai a data inicial, e apresenta a quantidade de dias entre elas
            Console.WriteLine(t);
        }
    }
}
