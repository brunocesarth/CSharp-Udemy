using System;
using System.Collections.Generic;
using System.Globalization;

namespace Codigo_043 {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionário: #{i}");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                listaDeFuncionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }
        }
    }
}
