using System;

namespace AulaConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float x = 4.5f;
            double y = x; //Conversão implicita de tipos

            Console.WriteLine(y);

            double a;
            float b;

            a = 5.1;
            b = (float) a; //Conversão explicita de tipos(CASTING)
            Console.WriteLine(b);

            double c;
            int d;
            c = 5.1;
            d = (int)c; //Conversão explicita de tipos(CASTING)
            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double)e / f; //Necessário CASTING para o resultado sair em double
            Console.WriteLine(resultado);
        }
    }
} 