using System;
using System.Globalization;

namespace Codigo_021 {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolár? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos doláres você vai comprar? ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = ConversorDeMoedas.Calcular(cotacao, valor);

            Console.WriteLine("Valor a ser pago em reais = " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
