using System;
using System.Globalization;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é $ {1:F2}", produto1, preco1);//PLACEHOLDER
            Console.WriteLine("{0}, cujo preco é $ {1:F2}", produto2, preco2);//PLACEHOLDER
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, códgio {codigo} e gênero: {genero}");//INTERPOLAÇÃO
            Console.WriteLine();
            Console.WriteLine("Medida com oito casa decimais: " + medida.ToString("F8"));//CONCATENAÇÃO
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));//CONCATENAÇÃO
            Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));//CONCATENAÇÃO
        }
    }
}
