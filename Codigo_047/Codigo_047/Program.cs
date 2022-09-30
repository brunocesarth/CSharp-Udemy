using System;

namespace Codigo_047 {
    class Program {
        static void Main(string[] args) {
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            var w = z;
            //int a = z; Não deixa, pq são tipos diferentes

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
