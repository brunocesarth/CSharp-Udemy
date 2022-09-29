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
                listaDeFuncionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Qual o id do funcionário que irá receber aumento: ");
            int buscaId = int.Parse(Console.ReadLine());

            Funcionario func = listaDeFuncionarios.Find(x => x.Id == buscaId);

            if (func != null) {
                Console.Write("Qual a porcentagem será aumentada no salário? ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentaSalario(porcentagem);
            } else {
                Console.WriteLine("O ID informado não foi encontrado.");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de funcionários");
            foreach (Funcionario obj in listaDeFuncionarios) {
                Console.WriteLine(obj);
            }
        }
    }
}