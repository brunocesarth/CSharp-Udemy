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
                listaDeFuncionarios.Add(funcionario = new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do funcionário que irá receber um aumento de salário: ");
            id = int.Parse(Console.ReadLine());


            foreach (Funcionario obj in listaDeFuncionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}
