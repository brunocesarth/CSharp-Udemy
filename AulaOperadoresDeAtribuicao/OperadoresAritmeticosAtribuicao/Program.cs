using System;

namespace OperadoresAritmeticosAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            a++;
            Console.WriteLine(a);

            int b = 10;
            b--;
            Console.WriteLine(b);

            int c = 10;
            int d = c++; // Primeiro joga o valor de a para b, e depois incrementa a.
            Console.WriteLine(c);
            Console.WriteLine(d);

            int e = 10;
            int f = ++e; // Primeiro incrementa o valor da variável a, e depois ele atribui o resultado a b.
            Console.WriteLine(e);
            Console.WriteLine(f);
        }
    }
}
