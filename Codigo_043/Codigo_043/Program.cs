using System;
using System.Collections.Generic;
using System.Globalization;

namespace Codigo_043 {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> listaDeFuncionarios = new List<Funcionario>();
            Funcionario funcionario;
            int id;

            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Funcionário: #{i}");
                Console.Write("ID: ");
                id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionario = new Funcionario(id, nome, salario);
                listaDeFuncionarios.Add(funcionario);
                Console.WriteLine();
            }

            Console.Write("Qual o id do funcionário que irá receber aumento: ");
            id = int.Parse(Console.ReadLine());
            Funcionario funcionario1 = new Funcionario(id);

            listaDeFuncionarios.Contains(funcionario1);

            Console.WriteLine(funcionario1);
        }
    }
}