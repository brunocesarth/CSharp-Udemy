using System;
using System.Globalization;

namespace Codigo_012 {
    class Program {
        static void Main(string[] args) {
            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = calculaMedia(func1.Salario, func2.Salario);

            Console.WriteLine("Salário médio =  " + media.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double calculaMedia(double salario1, double salario2) {
            double media = (salario1 + salario2) / 2.0;
            return media;
        }
    }
}
