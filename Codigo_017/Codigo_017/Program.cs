using System;
using System.Globalization;

namespace Codigo_017 {
    class Program {
        static void Main(string[] args) {

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota Final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.Status());
            
            if (aluno.NotaFinal() < 60.00) {
                Console.WriteLine("Faltaram " + aluno.NotaFaltante() + " Pontos");
            }
        }
    }
}
