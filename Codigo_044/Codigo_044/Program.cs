using System;

namespace Codigo_044 {
    class Program {
        static void Main(string[] args) {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); //Fala quantos elementos tem na matriz
            Console.WriteLine(mat.Rank); //Quanto é a primeira dimensão da matriz(linhas)
            Console.WriteLine(mat.GetLength(0)); //Mostra o tamanho da matriz na primeira dimensão(linha)
            Console.WriteLine(mat.GetLength(1)); //Mostra o tamanho da matriz na segunda dimensão(coluna)
        }
    }
}
