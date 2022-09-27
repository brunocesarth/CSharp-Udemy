using System;

namespace Codigo_038 {
    class Program {
        static void Main(string[] args) {
            int a = 10;
            Calculator.Triple(ref a);
            Console.WriteLine(a);
        }
    }
}
