using System;

namespace AulaOperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            Console.WriteLine(n1);

            int n2 = (3 + 4) * 2;
            Console.WriteLine(n2);

            int n3 = 17 % 3;
            Console.WriteLine(n3);

            double n4 = (double) 10 / 8; //CASTING
            Console.WriteLine(n4);

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; //Math.pow = usada para potenciação

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt = raiz quadrada
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a); //Math.Sqrt = raiz quadrada

            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
