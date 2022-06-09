using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte x = 100;
            byte n1 = 126;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //Recomendado ao se trabalhar com a variável long, colocar L ao final do número.
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";//Pode ser atribuido qualquer valor como string
            object obj2 = 4.5f;//OU float
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine("O valor da variável sbyte é " + x);
            Console.WriteLine("O valor da variável byte é " + n1);
            Console.WriteLine("O valor da variável int(n2) é " + n2);
            Console.WriteLine("O valor da variável int(n3) é " + n3);
            Console.WriteLine("O valor da variável long " + n4);
            Console.WriteLine("O valor inicial da variável bool é " + completo);
            Console.WriteLine("O valor da variável char(genero) é " + genero);
            Console.WriteLine("O valor da variável char(letra) é " + letra);
            Console.WriteLine("O valor da variável float é " + n5);
            Console.WriteLine("O valor da variável double é " + n6);
            Console.WriteLine("O valor da variável string é " + nome);
            Console.WriteLine("O valor da variável object(obj1) é " + obj1);
            Console.WriteLine("O valor da variável object(obj2) é " + obj2);
            Console.WriteLine("O valor da variável int.MinValue é " + n7);
            Console.WriteLine("O valor da variável int.MaxValue é " + n8);
            Console.WriteLine("O valor da variável sbyte.MinValue é " + n9);
            Console.WriteLine("O valor da variável decimal.MaxValue é " + n10);
        }
    }
}
