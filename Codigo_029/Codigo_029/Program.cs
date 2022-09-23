using System;
using System.Globalization;

namespace Codigo_029 {
    class Program {
        static void Main(string[] args) {
            double valor = 0.0;
            Conta conta = new Conta(null, 0, 0.0);
            
            Console.Write("Entre com o número da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular da conta: ");
            conta.Nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n) ? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's'  || resposta == 'S') {
                Console.Write("Entre com o valor depósito inicial: ");
                valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valor);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}
